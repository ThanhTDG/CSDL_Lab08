using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CategoryBUS
    {
        private static CategoryBUS instance;

        public static CategoryBUS Instance
        {
            get { if (instance == null) instance = new CategoryBUS(); return instance; }
            private set { instance = value; }
        }
        public List<Category> GetAll()
        {
            return CategoryDAO.Instance.GetAll();
        }
        public int Insert(Category category)
        {
            return CategoryDAO.Instance.Insert(category);
        }
        public int Update(Category category)
        {
            return CategoryDAO.Instance.Update(category);
        }

        public int Delete(Category category)
        {
            return CategoryDAO.Instance.Delete(category.ID);
        }
       
    }
}
