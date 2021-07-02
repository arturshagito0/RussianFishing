using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp3
{
    public static class InventoryGridHandler
    {

        public static void ShowItems<T>(DataGridView datagrid, Inventory inventory) where T : InventoryObject
        {
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.RowTemplate.Height = 18;
            datagrid.Columns.Clear();
            datagrid.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn onlyColumn = new DataGridViewTextBoxColumn();
            onlyColumn.DataPropertyName = "name";
            datagrid.Columns.Add(onlyColumn);
            datagrid.DataSource = inventory.GetItemsOfSpecificType<T>();

        }


    }
}
