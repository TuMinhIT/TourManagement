//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using HOMEPAGE.Services;
//using TourManagementApp.Utils;

//namespace HOMEPAGE
//{
//    static class FileServices
//    {
//        public static async Task<int> InsertFile(string filePath,string employessID)
//        {
//            int fileId = -1;

//            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(employessID))
//            {
//                return fileId;
//            }

//            try
//            {
//                using (SqlConnection sqlConnection = Connenction.GetSqlConnection("QUAN_LI_NHAN_VIEN"))
//                {
//                    byte[] fileData;
//                    using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
//                    {
//                        using (BinaryReader reader = new BinaryReader(stream))
//                        {
//                            fileData = reader.ReadBytes((int)stream.Length);
//                        }
//                    }
//                    await sqlConnection.OpenAsync();
//                    string insertQuery = @"
//                    INSERT INTO Files (Ma_Nhan_Vien, FileName, FileExtension, FileData) 
//                    OUTPUT INSERTED.FileID
//                    VALUES (@Ma_Nhan_Vien, @FileName, @FileExtension, @FileData)";
//                    SqlCommand command = new(insertQuery, sqlConnection);
//                    command.Parameters.AddWithValue("@Ma_Nhan_Vien", employessID);
//                    command.Parameters.AddWithValue("@FileName", SqlDbType.VarChar).Value = Path.GetFileName(filePath);
//                    command.Parameters.AddWithValue("@FileExtension", SqlDbType.VarChar).Value = Path.GetExtension(filePath);
//                    command.Parameters.AddWithValue("@FileData", SqlDbType.VarBinary).Value = fileData;
//                    fileId = (int)(await command.ExecuteScalarAsync());
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error : " + ex.Message);
//            }
//            return fileId;
//        }

//        public static async Task<(byte[] fileData, string fileName)> GetFileDataFromDatabase(string query, SqlParameter[] parameters)
//        {
//            byte[] fileData = null;
//            string fileName = null;

//            using (var connection = Connenction.GetSqlConnection("QUAN_LI_NHAN_VIEN"))
//            {
//                await connection.OpenAsync();

//                using (var command = new SqlCommand(query, connection))
//                {
//                    command.Parameters.AddRange(parameters);

//                    using (var reader = await command.ExecuteReaderAsync())
//                    {
//                        if (await reader.ReadAsync())
//                        {
//                            var fileDataOrdinal = reader.GetOrdinal("FileData");
//                            var fileNameOrdinal = reader.GetOrdinal("FileName");

//                            if (!reader.IsDBNull(fileDataOrdinal))
//                            {
//                                fileData = (byte[])reader[fileDataOrdinal];
//                            }

//                            if (!reader.IsDBNull(fileNameOrdinal))
//                            {
//                                fileName = reader.GetString(fileNameOrdinal);
//                            }
//                        }
//                    }
//                }
//            }

//            return (fileData, fileName);
//        }
//        public static async Task<int> InsertFileWithStreaming(string filePath, string employeeID)
//        {
//            int fileId = -1;

//            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(employeeID))
//            {
//                return fileId;
//            }

//            try
//            {
//                using (SqlConnection sqlConnection = Connenction.GetSqlConnection("QUAN_LI_NHAN_VIEN"))
//                {
//                    await sqlConnection.OpenAsync();

//                    string insertQuery = @"
//                                        INSERT INTO Files (Ma_Nhan_Vien, FileName, FileExtension) 
//                                        OUTPUT INSERTED.FileID
//                                        VALUES (@Ma_Nhan_Vien, @FileName, @FileExtension);
//                                        SELECT CAST(scope_identity() AS int);";

//                    string filename = Path.GetFileName(filePath);
//                    string fileExtension = Path.GetExtension(filePath);

//                    using (SqlCommand command = new SqlCommand(insertQuery, sqlConnection))
//                    {
//                        command.Parameters.AddWithValue("@Ma_Nhan_Vien", employeeID);
//                        command.Parameters.AddWithValue("@FileName", filename);
//                        command.Parameters.AddWithValue("@FileExtension", fileExtension);

//                        // Execute the insert command and get the inserted FileID
//                        fileId = (int)await command.ExecuteScalarAsync();
//                    }

//                    if (fileId > -1)
//                    {
//                        // Now insert the file content
//                        string updateBlobQuery = "UPDATE Files SET FileData = @FileData WHERE FileID = @FileID";
//                        using (SqlCommand updateCommand = new SqlCommand(updateBlobQuery, sqlConnection))
//                        {
//                            updateCommand.Parameters.Add("@FileID", SqlDbType.Int).Value = fileId;
//                            updateCommand.Parameters.Add("@FileData", SqlDbType.VarBinary, -1); // -1 for VARBINARY(MAX)

//                            // Use FileStream to read the file in chunks
//                            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
//                            {
//                                // Create a buffer to hold each chunk
//                                byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
//                                int bytesRead;
//                                long offset = 0; // This is the offset for the blob

//                                // Read the file in chunks
//                                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
//                                {
//                                    // Get the actual buffer that needs to be written
//                                    byte[] actualBuffer = new byte[bytesRead];
//                                    Array.Copy(buffer, actualBuffer, bytesRead);

//                                    // Set the parameters for the update command
//                                    updateCommand.Parameters["@FileData"].Value = actualBuffer;
//                                    updateCommand.Parameters["@FileData"].Size = bytesRead; // Set the actual size of the data being sent

//                                    // Execute the command to update the blob
//                                    await updateCommand.ExecuteNonQueryAsync();

//                                    // Increase the offset by the number of bytes read
//                                    offset += bytesRead;
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                // Handle exception
//                fileId = -1; // Reset file id on failure
                            
//            }

//            return fileId;
//        }



//    }

//}
