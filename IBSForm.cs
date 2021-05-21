using DatabaseSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBS
{
    public partial class IBSForm : DarkUI.Forms.DarkForm
    {
        public IBSForm()
        {
            InitializeComponent();
        }

        private void IBSForm_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext.NewDatabase();
                DatabaseContext.NewPlayerTable();
                ShowGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void ShowGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DatabaseContext.GetPlayer();
                PlyrGrid.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
