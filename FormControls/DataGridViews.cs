using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI;
using DarkUI.Controls;

namespace FormControls
{
    class DataGridViews
    {
        public static DataGridView NewDataGrid(DataGridView datagridview, int x, int y, int width, int height, string name)
        {
            datagridview.BackgroundColor = Color.FromArgb(60, 63, 65);
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 63, 65);
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridview.DefaultCellStyle.BackColor = Color.FromArgb(60, 63, 65);
            datagridview.DefaultCellStyle.ForeColor = Color.White;
            datagridview.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            datagridview.GridColor = Color.DimGray;

            datagridview.AllowDrop = false;
            datagridview.AllowUserToAddRows = false;
            datagridview.AllowUserToResizeRows = false;
            datagridview.AllowUserToDeleteRows = false;
            datagridview.AllowUserToOrderColumns = false;
            datagridview.AllowUserToResizeColumns = false;
            datagridview.ReadOnly = true;
            datagridview.Name = name;
            datagridview.Location = new Point(x, y);
            datagridview.Size = new Size(width, height);
            datagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagridview.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            datagridview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            if (datagridview.RowCount == 0 && name == "PlayerGrid")
            {
                datagridview.Columns.Add("Level", "Level");
                datagridview.Columns.Add("Exp", "Exp");
                datagridview.Columns.Add("Attack", "Attack");
                datagridview.Columns.Add("Defense", "Defense");
                datagridview.Columns.Add("MagicAttack", "Magic Attack");
                datagridview.Columns.Add("MagicDefense", "Magic Defense");
                datagridview.Columns.Add("Speed", "Speed");
                datagridview.Columns.Add("HitPoints", "Hit Points");
            }
            return datagridview;
        }
    }
}
