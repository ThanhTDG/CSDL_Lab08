using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911205_NguyenHuuDucThanh_Lab08
{
    public partial class Form1 : Form
    {
        List<Food> foodList = new List<Food>();
        List<Category> cateList = new List<Category>();
        Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
        Food foodCurrent;
        Category cateCrurent;
        public Form1()
        {
            InitializeComponent();
        }


        private void LoadCategory()
        {
            cateList = CategoryBUS.Instance.GetAll();
            cbbCategory.DataSource = cateList;
            cbbCategory.ValueMember = "ID";
            cbbCategory.DisplayMember = "Name";
           
      
        }
        private void LoadCatetype()
        {
            keyValuePairs.Add(0, "Thức uống");
            keyValuePairs.Add(1, "Thức ăn");
            cbbCateType.Items.Add(keyValuePairs[0]);
            cbbCateType.Items.Add(keyValuePairs[1]);
        }
        private void Message(int result, string action)
        {
            if (result > 0)
            {
                MessageBox.Show(action + " dữ liệu thành công");
            }
            else
            {
                MessageBox.Show(action + " dữ liệu không thành công.Vui lòng kiểm tra lại");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFoodToLV();
            LoadCatetype();
            LoadCateToListView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadCateToListView()
        {
            int count = 1;
            lsvCate.Items.Clear();
            foreach (var category in cateList)
            {
                ListViewItem item = lsvCate.Items.Add(category.ID.ToString());
                item.SubItems.Add(count.ToString());
                item.SubItems.Add(category.Name);
                 item.SubItems.Add(keyValuePairs[category.Type]);
                count++;
            }
            lsvCate.Columns[0].Width = 0;
        }
        private void LoadFoodToLV(List<Food> foodList = null)
        {
            int count = 1;
            if (foodList == null)
                this.foodList = foodList = FoodBUS.Instance.GetAll();
            lvsFood.Items.Clear();
            foreach (var food in foodList)
            {
                ListViewItem item = lvsFood.Items.Add(food.ID.ToString());
                item.SubItems.Add(count.ToString());
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.Price.ToString());
                string foodName = cateList.Find(x => x.ID == food.CategoryID).Name;
                item.SubItems.Add(foodName);
                item.SubItems.Add(food.Note);
                count++;
            }
            lvsFood.Columns[0].Width = 0;
        }
        private void lvsFood_Click(object sender, EventArgs e)
        {
            if (lvsFood.SelectedItems.Count == 0)
                return;
            tabFuncion.SelectedIndex = 0;
            foodCurrent = foodList.Find(x => x.ID == int.Parse(lvsFood.SelectedItems[0].Text));
            txtName.Text = foodCurrent.Name;
            txtUnit.Text = foodCurrent.Unit;
            txtPrice.Text = foodCurrent.Price.ToString();
            txtNote.Text = foodCurrent.Note;
            cbbCategory.SelectedValue = foodCurrent.CategoryID;

        }
        private void loadCate()
        {
            grBox.Text = "Loại món ăn";
        }
        public int InsertOrUpdateFood(bool insert)
        {
            Food food;
            if (insert)
            {
                food = new Food();
                food.ID = 0;
            }
            else
            {
                food = foodCurrent;
            }
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Note = txtNote.Text;
                int price = 0;
                try
                {
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    price = 0;
                }
                food.Price = price;
                food.CategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                if (insert)
                    return FoodBUS.Instance.Insert(food);
                else
                    return FoodBUS.Instance.Update(food);
            }
            return -1;
        }
        public int InsertOrUpdateCate(bool insert)
        {
            Category category;
            if (insert)
            {
                category = new Category();
                category.ID = 0;
            }
            else
            {
                category = cateCrurent;
            }
            if (txtCateName.Text == ""|| cbbCateType.SelectedIndex == -1)
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                category.Name = txtCateName.Text;
                category.Type = cbbCategory.SelectedIndex; 
                if (insert)
                    return CategoryBUS.Instance.Insert(category);
                else
                    return CategoryBUS.Instance.Update(category);
            }
            return -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = InsertOrUpdateFood(true);
                if (result > 0)
                {
                    if (tabFuncion.SelectedIndex == 0)
                        LoadFoodToLV();
                    else
                        LoadFoodToLV(foodList.FindAll(x => x.CategoryID == foodCurrent.CategoryID).ToList());
                }
            Message(result, "Thêm");
        }


        private void tabFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabFuncion.SelectedIndex)
            {
                case 0:
                    grBox.Text = "Danh sách món ăn";
                    break;
                case 1:
                    loadCate();
                    break;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUnit.Text = "";
            txtPrice.Text = "";
            txtNote.Text = "";
            cbbCategory.SelectedIndex = -1;
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadFoodToLV();
        }

        private void btnResetCate_Click(object sender, EventArgs e)
        {
            txtCateName.Text = "";
            cbbCateType.SelectedIndex = -1;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            tabFuncion.SelectedIndex = 0;
            if (cbbCateType.SelectedIndex < 0)
            {
                btnLoadAll.PerformClick();
                btnReload.PerformClick();
            }
            else
            {
                cbbCategory.SelectedValue = cateCrurent.ID;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = InsertOrUpdateFood(false);
            if(result > 0)
            {
                if (cbbCateType.SelectedIndex == -1)
                    LoadFoodToLV();
                else
                {
                    cbbCategory.SelectedValue = cateCrurent.ID;
                    LoadFoodToLV(foodList.FindAll(x => x.CategoryID == foodCurrent.CategoryID).ToList());
                }
            }
               
            Message(result, "Cập nhật");
        }

        private void lsvCate_Click(object sender, EventArgs e)
        {
            if (lsvCate.SelectedItems.Count == 0)
                return;
            int id = int.Parse(lsvCate.SelectedItems[0].Text);
            LoadFoodToLV(foodList.FindAll(x => x.CategoryID == id).ToList());
            cateCrurent = cateList.Find(x => x.ID == id);
            txtCateName.Text = cateCrurent.Name;
            cbbCateType.SelectedIndex = cateCrurent.Type;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = InsertOrUpdateCate(true);
                if (result > 0)
                {
                    LoadCategory();
                    LoadCateToListView();
                    btnResetCate.PerformClick();
                }
            Message(result, "Thêm");
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lsvCate.SelectedItems.Count == 0)
                return;
            int result = CategoryBUS.Instance.Delete(cateCrurent);
             if (result > 0)
                {
                    LoadCategory();
                    LoadCateToListView();
                    btnResetCate.PerformClick();
                }
            Message(result, "Xóa");

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvsFood.SelectedItems.Count == 0)
                return;
            int result = FoodBUS.Instance.Delete(foodCurrent.ID);
            if (result > 0)
            {
                if (cbbCateType.SelectedIndex == -1)
                    LoadFoodToLV();
                else
                {
                    cbbCategory.SelectedValue = cateCrurent.ID;
                    LoadFoodToLV(foodList.FindAll(x => x.CategoryID == foodCurrent.CategoryID).ToList());
                }
            }
            Message(result, "Xóa");
        }

        private void btnUpdateCate_Click(object sender, EventArgs e)
        {
            if (lsvCate.SelectedItems.Count == 0)
                return;
            int result = InsertOrUpdateCate(false);
            if (result > 0)
            {
                LoadCategory();
                LoadCateToListView();
                btnResetCate.PerformClick();
            }
            Message(result, "Sửa");
        }
    }
}