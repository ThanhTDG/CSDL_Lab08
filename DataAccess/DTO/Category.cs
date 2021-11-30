using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public Category(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = (string)row["Name"];
            this.Type = (int)row["Type"];
           
        }
        public Category() { }

        public Category(int iD, string name, int type)
        {
            ID = iD;
            Name = name;
            Type = type;
        }
    }
}
