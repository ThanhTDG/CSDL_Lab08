using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess

{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO()  ; return instance; }
            private set { instance = value; }
        } 
        private FoodDAO() { }
        public List<Food> GetAll() {
            List<Food> list = new List<Food>();
            string Query = string.Format("Exec {0}", Ultilites.Food_GetAll);
            DataTable dt = DataProvider.Instance.ExcuteQuery(Query);
            foreach(DataRow row in dt.Rows)
            {
                Food food = new Food(row);
                list.Add(food);
            }
            return list;
        }

        public List<Food> GetFormCate(int _categoryID)
        {
            List<Food> list = new List<Food>();
            string Query = string.Format("Exec {0} @ID = {1}", Ultilites.Food_GetFormIDCate, _categoryID);
            DataTable dt = DataProvider.Instance.ExcuteQuery(Query);
            foreach (DataRow row in dt.Rows)
            {
                Food food = new Food(row);
                list.Add(food);
            }
            return list;
        }
        public int Update(Food food)
        {
            object[] obj = new object[6];
            obj[0] = food.ID;
            obj[1] = food.Name;
            obj[2] = food.Unit;
            obj[3] = food.CategoryID;
            obj[4] = food.Price;
            obj[5] = food.Note;
            string query = String.Format("EXEC {0} @ID , @Name , @Unit , @FoodCategoryID , @Price , @Notes ",Ultilites.Food_Update);
            return DataProvider.Instance.NonExcuteQuery(query, obj);
        }

        public int DeleteFood(int FoodId)
        {
            string query = String.Format("EXEC {0} @ID = "+FoodId , Ultilites.Food_Delete);
            return DataProvider.Instance.NonExcuteQuery(query);
        }
     
        public int InsertFood(Food food)
        {
            object[] obj = new object[5];
            obj[0] = food.Name;
            obj[1] = food.Unit;
            obj[2] = food.CategoryID;
            obj[3] = food.Price;
            obj[4] = food.Note;
            string query = String.Format("EXEC {0} @Name , @Unit , @FoodCategoryID , @Price , @Notes ",Ultilites.Food_Insert);
            return (int)DataProvider.Instance.ExcuteScalarQuery(query, obj);
        }
    }
}
