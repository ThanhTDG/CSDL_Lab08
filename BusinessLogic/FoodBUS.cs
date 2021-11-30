using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FoodBUS
    {
        private static FoodBUS instance;

        public static FoodBUS Instance
        {
            get { if (instance == null) instance = new FoodBUS(); return instance; }
            private set { instance = value; }
        }
        public List<Food> GetAll()
        {
            return FoodDAO.Instance.GetAll();
        }
        public List<Food> GetFormCate(int id)
        {
            return FoodDAO.Instance.GetFormCate(id);
        }
        public int Insert(Food food)
        {
            return FoodDAO.Instance.InsertFood(food);
        }
        public int Update(Food food)
        {
            return FoodDAO.Instance.Update(food);
        }
        public int Delete(int id)
        {
            return FoodDAO.Instance.DeleteFood(id);
        }
    }
}
