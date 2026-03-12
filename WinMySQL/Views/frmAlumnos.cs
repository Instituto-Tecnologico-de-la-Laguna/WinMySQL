using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;


namespace WinMySQL.Views
{
    public partial class frmAlumnos : Form
    {
        Datos datos = new Datos();
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            String path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdExcel.FileName;
                ExcelPackage.License.SetNonCommercialPersonal("Luis Mota"); //Libreria funcion no Comercial
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;
                    DataTable dt = new DataTable();
                    for (int col = 1; col <= colCount; col++)
                    {
                        dt.Columns.Add(worksheet.Cells[1, col].Value.ToString());
                    }
                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow drNew = dt.NewRow();
                        for (int col = 1; col <= colCount; col++)
                        {
                            drNew[col - 1] = worksheet.Cells[row, col].Value.ToString();
                        }
                        dt.Rows.Add(drNew);
                        String comando = $"Insert Into Alumnos(nocontrol,nombre," +
                            $"paterno,materno) Values('{drNew.ItemArray[0]}','" +
                            $"{drNew.ItemArray[1]}','{drNew.ItemArray[2]}','" +
                            $"{drNew.ItemArray[3]}')";
                        datos.ejecutarComando(comando);

                    }
                    //dgvAlumnos.DataSource = dt;


                }
            }
        }


        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            Busqueda();

        }
        private void txtAlumno_TextChanged(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void Busqueda()
        {
            DataSet ds = datos.ejecutar($"Select nocontrol,nombre,paterno,materno From Alumnos" +
                $" Where nombre like '{txtAlumno.Text}%'");
            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
        }

    }

}
