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

namespace pp3
{
    public partial class FishshopForm : Form
    {
       
        public FishshopForm()
        {
            InitializeComponent();

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

        
    }
}
