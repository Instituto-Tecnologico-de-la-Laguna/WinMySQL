namespace WinMySQL.Views
{
    partial class frmCatalogoLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCursos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            Disponible = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            SuspendLayout();
            // 
            // dgvCursos
            // 
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Columns.AddRange(new DataGridViewColumn[] { id, Grupo, Disponible });
            dgvCursos.Location = new Point(32, 49);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.RowHeadersWidth = 62;
            dgvCursos.Size = new Size(695, 242);
            dgvCursos.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "CVE";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 150;
            // 
            // Grupo
            // 
            Grupo.HeaderText = "Grupo";
            Grupo.MinimumWidth = 8;
            Grupo.Name = "Grupo";
            Grupo.Width = 150;
            // 
            // Disponible
            // 
            Disponible.HeaderText = "Disponible";
            Disponible.MinimumWidth = 8;
            Disponible.Name = "Disponible";
            Disponible.Resizable = DataGridViewTriState.True;
            Disponible.Width = 150;
            // 
            // frmCatalogoLibros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 333);
            Controls.Add(dgvCursos);
            Name = "frmCatalogoLibros";
            Text = "frmCatalogoLibros";
            Load += frmCatalogoLibros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCursos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn Disponible;
    }
}