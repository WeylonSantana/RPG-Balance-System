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
    public class NumericUpDowns
    {
        public static DarkNumericUpDown NewNumeric(DarkNumericUpDown numeric, int x, int y, int value, int min, int max)
        {
            numeric.Location = new Point(x, y);
            numeric.Value = value;
            numeric.Minimum = min;
            numeric.Maximum = max;
            return numeric;
        }
    }
}
