namespace pryBarrazaAgendarContactos
{
    partial class frmverContactos
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
            lblDatosContactos = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            SuspendLayout();
            // 
            // lblDatosContactos
            // 
            lblDatosContactos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosContactos.Location = new Point(151, 39);
            lblDatosContactos.Name = "lblDatosContactos";
            lblDatosContactos.Size = new Size(380, 178);
            lblDatosContactos.TabIndex = 0;
            lblDatosContactos.Text = "label1";
            lblDatosContactos.Click += lblDatosContactos_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(406, 264);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(125, 47);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Enabled = false;
            btnAnterior.Location = new Point(151, 264);
            btnAnterior.Margin = new Padding(3, 2, 3, 2);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(138, 47);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // frmverContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(lblDatosContactos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmverContactos";
            Text = "frmverContactos";
            ResumeLayout(false);
        }

        #endregion

        private Label lblDatosContactos;
        private Button btnSiguiente;
        private Button btnAnterior;
    }
}