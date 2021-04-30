using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;

namespace pp3
{
    public partial class MainForm : Form


    {
        public ObjectInitializer initializer = new ObjectInitializer();
        public FishshopForm fishShopForm;
        public TravelForm travelForm;
        public Player currentPlayer;
        public System.Media.SoundPlayer onClickSound = new System.Media.SoundPlayer(Properties.ReelResouce.click1);
        public MainForm(Player player)
        {



            fishShopForm = new FishshopForm(initializer);
            travelForm = new TravelForm(player, initializer);
            currentPlayer = player;
            currentPlayer.currentBase = initializer.Maps.Find(e => e.mapName == "houm");

            InitializeComponent();
            fishShopForm.OnItemBought += MyForm_DataAvailable;
            EventHandlers.OnCanBeBought += MoneyChanged;
            EventHandlers.OnButtonClickSound += ButtonClickSound;
            moneyLabel.Text = $"Деньги: {StringFormatter.decimalFormat(this.currentPlayer.money.ToString(), StringFormatter.FORMAT_KIND.CURR)}";
            
        }

        private void ButtonClickSound(object sender, EventArgs e)
            
        {
            
            onClickSound.Play();
        }

        public void MoneyChanged(object sender, long money)
        {
            moneyLabel.Text = $"Деньги: {StringFormatter.decimalFormat(money.ToString(), StringFormatter.FORMAT_KIND.CURR)}";
        }

        private void MyForm_DataAvailable(object sender, EventArgs e)
        {
            FishshopForm child = sender as FishshopForm;
            if (child != null)
            {
                
                this.currentPlayer.playerInventory.addItem(child.selectedItem, currentPlayer);
                

            }
        }

       

       


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FishShopButton_MouseClick(object sender, MouseEventArgs e)
        {
            EventHandlers.OnButtonClickSound?.Invoke  (null, null);
            Thread.Sleep(150);
            fishShopForm.Show();
        }


        #region MouseHover

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

        #endregion 

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BaseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(this.currentPlayer.playerInventory.count.ToString() + "   " + this.currentPlayer.money);
            //DatabaseForm dbForm = new DatabaseForm();
            //dbForm.Show();
           
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            
        }

        private void MiddlePanel_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

        private void BasePanel_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Text = (e.X.ToString() + "    " +  (500 - e.Y).ToString());
        }

        private void TravelButton_Click(object sender, EventArgs e)
        {
            
            travelForm.Show();

        }

        private void FoodShopButton_Click(object sender, EventArgs e)
        {
            
        }

        private void FishShopButton_Click(object sender, EventArgs e)
        {

        }

        private void CurrentBase_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }
    }
}
