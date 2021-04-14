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
            
           
            datagrid.AutoGenerateColumns = true;
            datagrid.DataSource = selectedRods;
            datagrid.Columns[0].HeaderText = "Удилища";
            datagrid.Columns[1].HeaderText = "Выдерживает вес";
            datagrid.Columns[2].HeaderText = "Цена";
            datagrid.Columns[2].DefaultCellStyle.Format = "c0";
            datagrid.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("ru");
        }
    }

   
}
