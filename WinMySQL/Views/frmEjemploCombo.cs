using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmEjemploCombo : Form
    {
        Datos datos = new Datos();
        public frmEjemploCombo()
        {
            InitializeComponent();
        }

        private void frmEjemploCombo_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.ejecutar("Select CVE, Materia from Materias");
            if (ds != null)
            {
                cmbMaterias.Items.Clear();
                cmbMaterias.DataSource = ds.Tables[0];
                cmbMaterias.DisplayMember = "Materia";
                cmbMaterias.ValueMember = "CVE";
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La materia seleccionada es {cmbMaterias.Text} con clave {cmbMaterias.SelectedValue}");
        }
    }
}
