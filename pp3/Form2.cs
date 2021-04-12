using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void listView1_Click(object sender, EventArgs e)
        {
            string name = listView1.SelectedItems[0].SubItems[0].Text;
            string maxWeight = listView1.SelectedItems[0].SubItems[1].Text;
            string price = listView1.SelectedItems[0].SubItems[1].Text;

            string poplabel = "Поплавочное удилище";
            Description.Text = poplabel;
            Price.Text = $"Цена: {price}";
            MaxWeight.Text = $"Выдерживает вес: {maxWeight}";
            NameOfItem.Text = name;





            
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
            Price.Text = $"Цена: {selectedRod.price}";
            NameOfItem.Text = selectedRod.name;
            MaxWeight.Text = $"Выдерживает: {selectedRod.maxWeight}";
        }
    }
}
