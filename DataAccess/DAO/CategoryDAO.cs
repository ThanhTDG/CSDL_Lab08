using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }

        public List<Category> GetAll()
        {
            List<Category> list = new List<Category>();
            string Query = string.Format("Exec {0}", Ultilites.Category_GetAll);
            DataTable dt = DataProvider.Instance.ExcuteQuery(Query);
            foreach (DataRow row in dt.Rows)
            {
                Category food = new Category(row);
                list.Add(food);
            }
            return list;
        }

       
        public int Update(Category category)
        {
            string query = String.Format("EXEC {0} @ID , @Name , @Type ", Ultilites.Category_Update);
            return DataProvider.Instance.NonExcuteQuery(query, new object[] { category.ID, category.Name, category.Type });
        }

        public int Delete(int Id)
        {
            string query = String.Format("EXEC {0} @ID =" + Id, Ultilites.Category_Delete);
            return DataProvider.Instance.NonExcuteQuery(query);
        }

        public int Insert(Category category)
        {
            string query = String.Format("EXEC {0} @Name , @Type ", Ultilites.Category_Insert);
            return (int)DataProvider.Instance.NonExcuteQuery(query, new object[] { category.Name, category.Type });
        }
    }

}
