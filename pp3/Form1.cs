using System;
using System.Windows.Forms;


namespace pp3
{
    public partial class MainForm : Form
    {
        public FishshopForm myForm = new FishshopForm();
        public Player currentPlayer;
        public System.Media.SoundPlayer onClickSound = new System.Media.SoundPlayer(Properties.ReelResouce.click1);
        public MainForm(Player player)
        {
            currentPlayer = player;
            InitializeComponent();
            myForm.OnItemBought += MyForm_DataAvailable;

        }

        private void MyForm_DataAvailable(object sender, EventArgs e)
        {
            FishshopForm child = sender as FishshopForm;
            if (child != null)
            {
                this.currentPlayer.playerInventory.addItem(child.selectedItem);

            }
        }

       

       


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FishShopButton_MouseClick(object sender, MouseEventArgs e)
        {
            myForm.Show();
            onClickSound.Play();
            MessageBox.Show(Application.StartupPath);
            Properties.Loc
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.currentPlayer.playerInventory.count.ToString());
        }

        private void BaseButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
