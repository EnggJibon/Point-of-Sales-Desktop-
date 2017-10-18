using System.Drawing;
using System.Windows.Forms;

namespace POS.UTILS
{
    public static class Helper
    {
        public static void InitializeComboBox(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Font = new Font(comboBox.Font, FontStyle.Regular);
        }

        public static void InitializeDataGridView(DataGridView dataGridView)
        {
            dataGridView.Dock = DockStyle.Top;
            //dgvModuleList.BackgroundColor = Color.LightGray;
            //dgvModuleList.BorderStyle = BorderStyle.Fixed3D;

            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoGenerateColumns = false;

            dataGridView.ReadOnly = true;
            //for (int colIndex = 0; colIndex < dataGridView.Columns.Count; colIndex++)
            //{
            //    var dataGridViewColumn = dataGridView.Columns[colIndex];
            //    if (dataGridViewColumn != null)
            //    {
            //        dataGridViewColumn.ReadOnly = true;
            //    }
            //}

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            //dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //dgvModuleList.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            //dgvModuleList.DefaultCellStyle.SelectionForeColor = Color.Black;
            //dgvModuleList.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

            //dgvModuleList.RowsDefaultCellStyle.BackColor = Color.White;
            //dgvModuleList.AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon;

            //dgvModuleList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Wheat;
            //dgvModuleList.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            //dgvModuleList.RowHeadersDefaultCellStyle.BackColor = Color.Red;

            // Set the Format property on the "Last Prepared" column to cause
            // the DateTime to be formatted as "Month, Year".
            //dataGridView1.Columns["Last Prepared"].DefaultCellStyle.Format = "y";          
        }
    }
}
