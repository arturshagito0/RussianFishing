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
            GameRods init = new GameRods();
            init.InitializeAllRods();



            List<Rod> selectedRods = init.getAllRods().FindAll(e => e.getRodType() == type && e.getUniqueness() == unique); ;
            
 
            datagrid.AutoGenerateColumns = false;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.DataSource = selectedRods;
            

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
    }

   
}
