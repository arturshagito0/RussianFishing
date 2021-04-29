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
    public partial class DatabaseForm : Form
    {
        public Database1DataSet1TableAdapters.MapsTableAdapter mapAdapter;
        
        public DatabaseForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.mapsTableAdapter.Insert($"N'{textBox1.Text}'", textBox2.Text);
           // database1DataSet1.AcceptChanges();
            //this.mapsTableAdapter.Fill(this.database1DataSet1.Maps);




        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Maps' table. You can move, or remove it, as needed.
            // mapAdapter = new Database1DataSet1TableAdapters.MapsTableAdapter();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ObjectInitializer.InitializeAllMaps();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
