using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Globalization;

namespace pp3
{
    public partial class FishshopForm : Form
    {
       
        public FishshopForm()
        {

            Load += RodButton_Click;
           
            Load += poplavokButton_Click;
            InitializeComponent();
            DrawingControl.SetDoubleBuffered(dataGridView1);

            

           
            
            }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FishshopForm_Load(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaxWeight_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RodButton_Click(object sender, EventArgs e)
        {
            RodButton.BackColor = System.Drawing.Color.LightSkyBlue;
            rodLabel.BackColor = System.Drawing.Color.LightSkyBlue;

           
            



        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Rod selectedRod = (Rod)dataGridView1.CurrentRow.DataBoundItem;
            if (selectedRod.getRodType() == Rod.ROD_TYPE.POPLAVOK)
            {
                Description.Text = "Поплавочное удилище";

            }

            else
            {
                Description.Text = "Спиннинг";
            }



            var c = StringFormatter.FORMAT_KIND.CURR;
            var m = StringFormatter.FORMAT_KIND.WEIGHT;

            Bitmap im = (Bitmap)Properties.Resources.ResourceManager.GetObject(selectedRod.rodName);

            StringFormatter formatter = new StringFormatter();

            

            pictureBox1.Image = im;
            
            Price.Text = $"Цена: {formatter.decimalFormat(selectedRod.price.ToString(), c)}";
            NameOfItem.Text = selectedRod.rodName;
            MaxWeight.Text = $"Выдерживает: {formatter.decimalFormat(selectedRod.maxWeight.ToString(), m)}";
        }

        private void poplavokButton_MouseEnter(object sender, EventArgs e)
        {
            poplavokButton.Image = pp3.Properties.Resources.cat_popl_a;
            
        }

        private void poplavokButton_Click(object sender, EventArgs e)
        {
            poplavokButton.Image = pp3.Properties.Resources.cat_popl_s;
            Load += spinningButton_MouseLeave;
            ShopGridViewHandler.selectRods(Rod.ROD_TYPE.POPLAVOK, false, dataGridView1);
            

            
        }

       

       



        private void spinningButton_Click(object sender, EventArgs e)
        {
            spinningButton.Image = Properties.Resources.cat_spin_s;
            //poplavokButtonDisable();
            Load += poplavokButton_MouseLeave;
            ShopGridViewHandler.selectRods(Rod.ROD_TYPE.SPINNING, false, dataGridView1);

            
        }

        private string changeLetter(string s, char c)
        {
            char[] chars = s.ToCharArray();
            chars[s.Length - 1] = c;
            return new string(chars);
        }

     

        private void poplavokButton_MouseLeave(object sender, EventArgs e)
        {
            poplavokButton.Image = Properties.Resources.cat_popl_d;
        }

        private void spinningButton_MouseEnter(object sender, EventArgs e)
        {
            spinningButton.Image = Properties.Resources.cat_spin_a;
            
        }

        private void spinningButton_MouseLeave(object sender, EventArgs e)
        {
            spinningButton.Image = Properties.Resources.cat_spin_d;
        }
    }
}
