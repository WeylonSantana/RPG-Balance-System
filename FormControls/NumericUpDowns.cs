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
        public static DarkNumericUpDown NewNumeric(DarkNumericUpDown numeric, int x, int y, int value, int min, int max, bool notint=false)
        {
            numeric.Location = new Point(x, y);
            numeric.Value = value;
            numeric.Minimum = min;
            numeric.Maximum = max;
            if(notint == true)
            {
                numeric.DecimalPlaces = 2;
                numeric.Increment = 0.01M;
            }
            return numeric;
        }
    }
}
