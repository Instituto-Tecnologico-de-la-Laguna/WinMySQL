namespace WinMySQL.Views
{
    partial class frmEjemploCombo
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
            btnEnviar = new Button();
            cmbMaterias = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(511, 62);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 34);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(34, 64);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(452, 33);
            cmbMaterias.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 2;
            label1.Text = "Materias";
            // 
            // frmEjemploCombo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 138);
            Controls.Add(label1);
            Controls.Add(cmbMaterias);
            Controls.Add(btnEnviar);
            Name = "frmEjemploCombo";
            Text = "Ejemplo";
            Load += frmEjemploCombo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private ComboBox cmbMaterias;
        private Label label1;
    }
}