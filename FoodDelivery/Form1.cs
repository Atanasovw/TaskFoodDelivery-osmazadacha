using FoodDelivery.Business;
using FoodDelivery.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodDelivery
{
    public partial class Form1 : Form
    {

        DishBusiness dishController = new DishBusiness();
        DishTypeBusiness typeController = new DishTypeBusiness();
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DishTypes> allTypes = typeController.GetAllDishеsOfTypes();
            typedishcombobox.DataSource = allTypes;
            typedishcombobox.DisplayMember = "Name";
            typedishcombobox.ValueMember = "Id";
            selectAllButton_Click(sender, e);
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            List<Dishes> allDishes = dishController.GetAll();
            listBox1.Items.Clear();
            foreach (var item in allDishes)
            {
                listBox1.Items.Add($"{item.Id}. {item.Name} - Price: {item.Price} Type:{item.DishTypeId}");
            }
        }
        private void LoadRecord(Dishes dish)
        {
            idtxtbox.BackColor = Color.White;
            idtxtbox.Text = dish.Id.ToString();
            nametxtbox.Text = dish.Name;
            pricetxtbox.Text = dish.Price.ToString();
            grammagetxtbox.Text = dish.Grammage.ToString();
            typedishcombobox.Text = dish.DishTypeId.ToString();
        }
        private void ClearScreen()
        {
            idtxtbox.BackColor = Color.White;
            idtxtbox.Clear();
            nametxtbox.Clear();
            pricetxtbox.Clear();
            grammagetxtbox.Clear();
            typedishcombobox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametxtbox.Text) || nametxtbox.Text == "")
            {
                MessageBox.Show("Въведете данни!");
                nametxtbox.Focus();
                return;
            }
            Dishes newDish = new Dishes();
            newDish.Price = double.Parse(pricetxtbox.Text);
            newDish.Name = nametxtbox.Text;
            newDish.Description = textBox1.Text;
            newDish.Grammage = double.Parse(grammagetxtbox.Text);
            //записва в таблицата Id на избрания елемент =>
            //Разлиства имената на типовете, а записва съответното Id
            newDish.Id = (int)typedishcombobox.SelectedValue;
            dishController.Create(newDish);
            MessageBox.Show("Записът е успешно добавен!");
            ClearScreen();
            selectAllButton_Click(sender, e);
            LoadRecord(newDish);
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {


        }

        private void findButton_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(idtxtbox.Text) || !idtxtbox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                idtxtbox.BackColor = Color.Red;
                idtxtbox.Focus();
                return;
            }
            else
            {
                findId = int.Parse(idtxtbox.Text);
            }
            Dishes findedDish = dishController.Get(findId);
            if (findedDish == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                idtxtbox.BackColor = Color.Red;
                idtxtbox.Focus();
                return;
            }
            LoadRecord(findedDish);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(idtxtbox.Text) || !idtxtbox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                idtxtbox.BackColor = Color.Red;
                idtxtbox.Focus();
                return;
            }
            else
            {
                findId = int.Parse(idtxtbox.Text);
            }
            //Ако няма намерен запис търсим по Id и визуализираме на екрана
            if (string.IsNullOrEmpty(nametxtbox.Text))
            {
                Dishes findedDish = dishController.Get(findId);
                if (findedDish == null)
                {
                    MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                    idtxtbox.BackColor = Color.Red;
                    idtxtbox.Focus();
                    return;
                }
                LoadRecord(findedDish);
            }
            else //Ако има намерен вече запис променяме по полетата
            {
                Dishes updatedDish = new Dishes();
                updatedDish.Name = nametxtbox.Text;
                updatedDish.Price = double.Parse(pricetxtbox.Text);
                updatedDish.DishTypeId = (int)typedishcombobox.SelectedValue;

                dishController.Update(findId, updatedDish);
            }

            selectAllButton_Click(sender, e);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(idtxtbox.Text) || !idtxtbox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                idtxtbox.BackColor = Color.Red;
                idtxtbox.Focus();
                return;
            }
            else
            {
                findId = int.Parse(idtxtbox.Text);
            }
            Dishes findedDish = dishController.Get(findId);
            if (findedDish == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                idtxtbox.BackColor = Color.Red;
                idtxtbox.Focus();
                return;
            }
            LoadRecord(findedDish);

            DialogResult answer = MessageBox.Show("Наистина ли искате да изтриете запис No " +
             findId + " ?", "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                dishController.Delete(findId);
            }
            btnSelectAll_Click(sender, e);
        }

        private void typedishcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
