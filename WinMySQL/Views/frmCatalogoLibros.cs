using FastReport.Barcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmCatalogoLibros : Form
    {
        Datos obj = new Datos();
        public frmCatalogoLibros()
        {
            InitializeComponent();
        }

        private void frmCatalogoLibros_Load(object sender, EventArgs e)
        {
            DataSet ds = obj.ejecutar("Select CVE, Materia from Materias");
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                
                foreach (DataRow row in dt.Rows)
                {
                    string cve = row["CVE"].ToString();
                    string materia = row["Materia"].ToString();
                    string sn = "S";
                    
                    dgvCursos.Rows.Add(cve, materia,sn);

                }

            }
        }
    }
}
