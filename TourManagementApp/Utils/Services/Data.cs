using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HOMEPAGE
{
    public  enum MaBoPhan
    {
        GD , // CEO
        AN, // An ninh
        DV, // HCNS và Dịch vụ Cư Dân
        TC, // Tài chính Kế toán
        VS, // Vệ sinh
        KT, // Kỹ thuật bảo trì
        XD  // Xây dựng
    }

    static class Data
    {
        public static string[] GetTenBoPhan()
        {
            return [ "An ninh", "HCNS và Dịch vụ Cư Dân", "Tài chính Kế toán", "Vệ sinh", "Kỹ Thuật bảo trì", "Xây dựng"];
        }
        public static Dictionary<MaBoPhan, string> MaBoPhanMapping = new Dictionary<MaBoPhan, string>
        {
            { MaBoPhan.GD, "Giám đốc" },
            { MaBoPhan.AN, "An ninh" },
            { MaBoPhan.DV, "HCNS và Dịch vụ Cư Dân" },
            { MaBoPhan.TC, "Tài chính Kế toán" },
            { MaBoPhan.VS, "Vệ sinh" },
            { MaBoPhan.KT, "Kỹ thuật bảo trì" },
            { MaBoPhan.XD, "Xây dựng" }
        };
        public static Dictionary<string, MaBoPhan> TenBoPhanMapping = new Dictionary<string, MaBoPhan>
        {
            { "Giám đốc", MaBoPhan.GD },
            { "An ninh", MaBoPhan.AN },
            { "HCNS và Dịch vụ Cư Dân", MaBoPhan.DV },
            { "Tài chính Kế toán", MaBoPhan.TC },
            { "Vệ sinh", MaBoPhan.VS },
            { "Kỹ thuật bảo trì", MaBoPhan.KT },
            { "Xây dựng", MaBoPhan.XD }
        };
    }
}
