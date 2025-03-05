using System;
using System.Data;
using ClosedXML.Excel;
using TourManagementApp.Models;

public class FileInteraction
{
    /// Xuất dữ liệu từ DataGridView ra file Excel
    public static bool ExportToExcel(DataGridView dataGridView, string filePath)
    {
        try
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                DataTable dt = new DataTable();

                // Tạo danh sách cột hợp lệ (bỏ qua "Detail" và "Delete")
                List<int> validColumnIndexes = new List<int>();

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Name != "Detail" && column.Name != "Delete")
                    {
                        dt.Columns.Add(column.HeaderText);
                        validColumnIndexes.Add(column.Index); 
                    }
                }

                // Duyệt từng dòng trong DataGridView
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < validColumnIndexes.Count; i++)
                        {
                            int colIndex = validColumnIndexes[i]; 
                            dr[i] = row.Cells[colIndex].Value ?? "";
                        }
                        dt.Rows.Add(dr);
                    }
                }

                // Xuất dữ liệu ra file Excel
                wb.Worksheets.Add(dt, "Sheet1");
                wb.SaveAs(filePath);
            }

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    /// Nhập dữ liệu từ file Excel vào gitview
    public static List<Customer> ImportCustomersFromExcel(string filePath)
    {
        List<Customer> customers = new List<Customer>();
        try
        {
            using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1);
                bool firstRow = true;

                foreach (IXLRow row in worksheet.RowsUsed())
                {
                    if (firstRow)
                    {
                        firstRow = false; 
                        continue;
                    }

                    Customer customer = new Customer
                    (row.Cell(1).GetString(),
                     row.Cell(2).GetString(),
                     row.Cell(3).GetString(),
                     row.Cell(4).GetString(),
                     row.Cell(5).GetString(),
                     row.Cell(6).GetString(),
                     row.Cell(7).GetString());
                    
                    customers.Add(customer);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi đọc file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return customers;
    }

    public static List<Tours> ImportTourFromExcel(string filePath)
    {
        List<Tours> list_tour = new List<Tours>();
        try
        {
            using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1);
                bool firstRow = true;

                foreach (IXLRow row in worksheet.RowsUsed())
                {
                    if (firstRow)
                    {
                        firstRow = false;
                        continue;
                    }
                    Tours tour = new Tours
                    (row.Cell(1).GetString(),
                     row.Cell(2).GetString(),
                     row.Cell(3).GetString(),
                     row.Cell(4).GetString(),
                     "",
                     row.Cell(5).GetString());

                    list_tour.Add(tour);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi đọc file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return list_tour;
    }
}
