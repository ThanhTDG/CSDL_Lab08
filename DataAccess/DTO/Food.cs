using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Food
    {
        int? iD;
        private string name;
        private string unit;
        private int categoryID;
        private int price;
        private string note;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public string Unit
        {
            get
            {
                return unit;
            }

            set
            {
                unit = value;
            }
        }
        public int CategoryID
        {
            get { return categoryID; }
            set
            {
                categoryID = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public string Note
        {
            get { return note; }
            set
            {
                note = value;
            }
        }
        public int ID
        {
            get { return iD.Value; }
            set
            {
                iD = value;
            }
        }
        public Food(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = (string)row["Name"];
            this.unit = (string)row["Unit"];
            this.categoryID = (int)row["FoodCateGoryID"];
            this.price = (int)row["Price"];
            this.note = row["Notes"] is DBNull ? "": (string)row["Notes"];
        }

        public Food() { }
        public Food( string name, string unit, int categoryID, int price, string note)
        {
            this.name = name;
            this.unit = unit;
            this.categoryID = categoryID;
            this.price = price;
            this.note = note;
        }
    }
}
