using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
    public class Ultilites
    {
        private static string StrName = "Connection";
        public static string ConnectionString = ConfigurationManager
            .ConnectionStrings[StrName]
            .ConnectionString;
        public static string Food_GetAll = "Food_GetAll";
        public static string Food_GetFormIDCate = "FP_GetFoodFromcategoryId";
        public static string Food_Insert = "InsertFood";
        public static string Food_Update = "CP_UpDateFood";
        public static string Food_Delete = "CP_RemoveFoodFromID";
        public static string Category_GetAll = "CP_GetCategory";
        public static string Category_Insert = "CP_InsertCategory";
        public static string Category_Update = "CP_UpdateCategoryFromID";
        public static string Category_Delete = "CP_RemoveCategoryFromID";
    }
}
