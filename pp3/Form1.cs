using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace pp3
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
		{

		}

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FoodShopButton_MouseHover(object sender, EventArgs e)
        {
			
        }

        private void FoodShopButton_MouseEnter(object sender, EventArgs e)
        {
			FoodShopButton.Image = pp3.Properties.Resources.base_food_a;
		}

        private void FishShopButton_MouseEnter(object sender, EventArgs e)
        {
			FishShopButton.Image = pp3.Properties.Resources.base_shop_a;
		}

        private void FishShopButton_MouseLeave(object sender, EventArgs e)
        {
			FishShopButton.Image = pp3.Properties.Resources.base_shop_d;
		}

        private void FishShopButton_MouseClick(object sender, MouseEventArgs e)
        {
			var myForm = new FishshopForm();
			myForm.Show();

            Rod rod = new Rod("atlanta", 500, 20000, Rod.ROD_TYPE.POPLAVOK);
            Rod rod2 = new Rod("Moch",  1500, 200000, Rod.ROD_TYPE.POPLAVOK);
            Rod srod = new Rod("Spin",  100, 10000, Rod.ROD_TYPE.SPINNING);
            List<Rod> rods = new List<Rod>{ rod, rod2, srod, rod, rod, rod, rod, rod, rod, rod, rod, rod, rod};


            DataGridView datagrid = (DataGridView)myForm.Controls.Find("dataGridView1", true)[0];
            datagrid.AutoGenerateColumns = true;
            datagrid.DataSource = rods;
            datagrid.Columns[0].HeaderText = "Удилища";
            datagrid.Columns[1].HeaderText = "Выдерживает вес";
            datagrid.Columns[2].HeaderText = "Цена";
            datagrid.Columns[2].DefaultCellStyle.Format = "c0";
            datagrid.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("ru");
            

            MessageBox.Show(datagrid.Columns[2].Name);

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                var val = datagrid[datagrid.Columns[2].DisplayIndex, i];
                 
            }

            
            

            ListViewItem item = new ListViewItem(rod.name);
            item.SubItems.Add(rod.maxWeight.ToString());
            item.SubItems.Add(rod.price.ToString());


            ListView listview = (ListView) myForm.Controls.Find("listView1", true)[0];
            listview.Items.Add(item);



        }

        private void FoodShopButton_MouseLeave(object sender, EventArgs e)
        {
			FoodShopButton.Image = pp3.Properties.Resources.base_food_d;
		}

        private void JunkShopButton_MouseEnter(object sender, EventArgs e)
        {
			JunkShopButton.Image = pp3.Properties.Resources.base_flea_a;

        }

        private void JunkShopButton_MouseLeave(object sender, EventArgs e)
        {
            JunkShopButton.Image = pp3.Properties.Resources.base_flea_d;
        }

        private void TravelButton_MouseEnter(object sender, EventArgs e)
        {
            TravelButton.Image = pp3.Properties.Resources.base_travel_a;
        }

        private void TravelButton_MouseLeave(object sender, EventArgs e)
        {
            TravelButton.Image = pp3.Properties.Resources.base_travel_d;
        }

        private void SellFishButton_MouseEnter(object sender, EventArgs e)
        {
            SellFishButton.Image = pp3.Properties.Resources.base_sell_a;
        }

        private void SellFishButton_MouseLeave(object sender, EventArgs e)
        {
            SellFishButton.Image = pp3.Properties.Resources.base_sell_d;
        }

        private void TackleboxButton_MouseEnter(object sender, EventArgs e)
        {
            TackleboxButton.Image = pp3.Properties.Resources.pack_a;
        }

        private void TackleboxButton_MouseLeave(object sender, EventArgs e)
        {
            TackleboxButton.Image = pp3.Properties.Resources.pack_d;
        }

        private void BackbackButton_MouseEnter(object sender, EventArgs e)
        {
            BackbackButton.Image = pp3.Properties.Resources.bag_a;
        }

        private void BackbackButton_MouseLeave(object sender, EventArgs e)
        {
            BackbackButton.Image = pp3.Properties.Resources.bag_d;
        }

        private void NotepadButton_MouseEnter(object sender, EventArgs e)
        {
            NotepadButton.Image = pp3.Properties.Resources.data_a;
        }

        private void NotepadButton_MouseLeave(object sender, EventArgs e)
        {
            NotepadButton.Image = pp3.Properties.Resources.data_d;
        }

        private void FoodButton_MouseEnter(object sender, EventArgs e)
        {
            FoodButton.Image = pp3.Properties.Resources.food_a;
        }

        private void FoodButton_MouseLeave(object sender, EventArgs e)
        {
            FoodButton.Image = pp3.Properties.Resources.food_d;
        }

        private void FishsackButton_MouseEnter(object sender, EventArgs e)
        {
            FishsackButton.Image = pp3.Properties.Resources.corf_a;
        }

        private void FishsackButton_MouseLeave(object sender, EventArgs e)
        {
            FishsackButton.Image = pp3.Properties.Resources.corf_d;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            TeamButton.Image = pp3.Properties.Resources.toteam_a;
        }

        private void TeamButton_MouseLeave(object sender, EventArgs e)
        {
            TeamButton.Image = pp3.Properties.Resources.toteam_d;
        }

        private void BaseButton_MouseEnter(object sender, EventArgs e)
        {
            BaseButton.Image = pp3.Properties.Resources.tobase_a;
        }

        private void BaseButton_MouseLeave(object sender, EventArgs e)
        {
            BaseButton.Image = pp3.Properties.Resources.tobase_d;
        }

        private void HomeButton_MouseEnter(object sender, EventArgs e)
        {
            HomeButton.Image = pp3.Properties.Resources.store_house_a;
        }

        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            HomeButton.Image = pp3.Properties.Resources.store_house_d;
        }

        private void CarButton_MouseEnter(object sender, EventArgs e)
        {
            CarButton.Image = pp3.Properties.Resources.store_car_a;
        }

        private void CarButton_MouseLeave(object sender, EventArgs e)
        {
            CarButton.Image = pp3.Properties.Resources.store_car_d;
        }
    }
}
