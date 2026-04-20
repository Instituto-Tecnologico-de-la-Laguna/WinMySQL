using WinMySQL.Views;

namespace WinMySQL
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias materias = new frmMaterias();
            materias.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos alumnos = new frmAlumnos();
            alumnos.ShowDialog();
        }

        private void ejemploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEjemploCombo ejemplo = new frmEjemploCombo();
            ejemplo.ShowDialog();
        }

        private void ejemplo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogoLibros catalogoLibros = new frmCatalogoLibros();
            catalogoLibros.ShowDialog();
        }
    }
}
