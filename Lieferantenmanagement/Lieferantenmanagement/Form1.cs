using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lieferantenmanagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "database1DataSet.Lieferanten". Sie können sie bei Bedarf verschieben oder entfernen.
            this.lieferantenTableAdapter.Fill(this.database1DataSet.Lieferanten);

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::Lieferantenmanagement.Properties.Settings.Default.Database1ConnectionString);

            try
            {
                string sql = "INSERT INTO Lieferanten (Lieferanten_Name) values('" + tbxAddSupplier.Text + "')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                this.lieferantenTableAdapter.Fill(this.database1DataSet.Lieferanten);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
