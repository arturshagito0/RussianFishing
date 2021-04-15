using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace pp3
{
    public static class ShopGridViewHandler

    {
        
    
        public static void selectRods(Rod.ROD_TYPE type, bool unique, DataGridView datagrid )
        {

            ObjectInitializer init = new ObjectInitializer();
            init.InitializeAllRods();

            var rods = init.getAllRods();


            List<Rod> uniqueRods = rods.FindAll(e => e.getUniqueness() == unique);
            List<Rod> selectedRods = rods.FindAll(e => e.getRodType() == type && e.getUniqueness() == unique); ;

            datagrid.Columns.Clear();
            datagrid.AutoGenerateColumns = false;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (unique)
            {
                datagrid.DataSource = uniqueRods;
            }

            else
            {
                datagrid.DataSource = selectedRods;
            }
            
            

            if (datagrid.Columns.Count == 0)
            {

                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "rodName";
                column1.Name = "Удилища";

                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "maxWeight";
                column2.Name = "Выдерживает вес";

                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.DataPropertyName = "price";
                column3.Name = "Цена";
                column3.DefaultCellStyle.Format = "c0";
                column3.DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("ru");

                datagrid.Columns.Add(column1);
                datagrid.Columns.Add(column2);
                datagrid.Columns.Add(column3);

            }
            
            
          
        }


        public static void selectReels(bool unique, DataGridView datagrid)

        {
            ObjectInitializer init = new ObjectInitializer();
            init.InitializeAllReels();
            var reels = init.getAllReels();
            
            List<Reel> selectedReels = reels.FindAll(e => e.getUniqueness() == unique);
            
            datagrid.Columns.Clear();
            datagrid.AutoGenerateColumns = false;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.DataSource = selectedReels;
           


            if (datagrid.Columns.Count == 0)
            {
                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
                column1.Name = "Катушка";
                column1.DataPropertyName = "name";

                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.Name = "Мощность";
                column2.DataPropertyName = "power";


                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.Name = "Цена";
                column3.DataPropertyName = "price";

                datagrid.Columns.Add(column1);
                datagrid.Columns.Add(column2);
                datagrid.Columns.Add(column3);
            }


        }

       

           

    }

   
}
