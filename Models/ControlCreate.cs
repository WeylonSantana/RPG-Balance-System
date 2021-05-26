using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI;
using DarkUI.Controls;
using IBS;

namespace Models
{
    class ControlCreate
    {
        public static void NewDataGrid()
        {
            IntersectBalanceSystem.dgvPlyr.Columns.Add("Level", "Level");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("Exp", "Exp");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("HitPoints", "Hit Points");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("Attack", "Attack");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("Defense", "Defense");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("MagicAttack", "Magic Attack");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("MagicDefense", "Magic Defense");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("Speed", "Speed");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("DamageTrue", "Damage True");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("CritDamageTrue", "Critical Damage True");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("DamageReal", "Damage Real");
            IntersectBalanceSystem.dgvPlyr.Columns.Add("CritDamageReal", "Critical Damage Real");

            IntersectBalanceSystem.dgvEny.Columns.Add("Level", "Level");
            IntersectBalanceSystem.dgvEny.Columns.Add("HitPoints", "Hit Points");
            IntersectBalanceSystem.dgvEny.Columns.Add("Attack", "Attack");
            IntersectBalanceSystem.dgvEny.Columns.Add("Defense", "Defense");
            IntersectBalanceSystem.dgvEny.Columns.Add("MagicAttack", "Magic Attack");
            IntersectBalanceSystem.dgvEny.Columns.Add("MagicDefense", "Magic Defense");
            IntersectBalanceSystem.dgvEny.Columns.Add("Speed", "Speed");
            IntersectBalanceSystem.dgvEny.Columns.Add("DamageTrue", "Damage True");
            IntersectBalanceSystem.dgvEny.Columns.Add("CritDamageTrue", "Critical Damage True");
            IntersectBalanceSystem.dgvEny.Columns.Add("DamageReal", "Damage Real");
            IntersectBalanceSystem.dgvEny.Columns.Add("CritDamageReal", "Critical Damage Real");

            IntersectBalanceSystem.dgvSummary.Columns.Add("PlyrLevel", "Player Level");
            IntersectBalanceSystem.dgvSummary.Columns.Add("HitsTrue", "Hits Damage True");
            IntersectBalanceSystem.dgvSummary.Columns.Add("HitsReal", "Hits Damage Real");
            IntersectBalanceSystem.dgvSummary.Columns.Add("EnyLevel", "Enemy Level");
            IntersectBalanceSystem.dgvSummary.Columns.Add("HitsTrue", "Hits Damage True");
            IntersectBalanceSystem.dgvSummary.Columns.Add("HitsReal", "Hits Damage Real");
        }
    }
}
