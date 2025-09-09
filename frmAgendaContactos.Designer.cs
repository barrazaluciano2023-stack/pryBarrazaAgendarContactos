namespace pryBarrazaAgendarContactos
{
    partial class frmAgendaContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendaContactos));
            txtNumero = new MaskedTextBox();
            lblContacto = new Label();
            lblNumero = new Label();
            txtContacto = new TextBox();
            btnAgendar = new Button();
            btnCancelar = new Button();
            lblCantidadContactos = new Label();
            lblFyH = new Label();
            lblTitulo = new Label();
            lstResultados = new RichTextBox();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Enabled = false;
            txtNumero.Font = new Font("Segoe UI", 14.25F);
            txtNumero.Location = new Point(187, 133);
            txtNumero.Mask = "(999)000-0000";
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(292, 33);
            txtNumero.TabIndex = 2;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 14.25F);
            lblContacto.Location = new Point(59, 79);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(88, 25);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 14.25F);
            lblNumero.Location = new Point(59, 141);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(81, 25);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Numero";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 14.25F);
            txtContacto.Location = new Point(187, 79);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(292, 33);
            txtContacto.TabIndex = 1;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // btnAgendar
            // 
            btnAgendar.Enabled = false;
            btnAgendar.Font = new Font("Segoe UI", 12F);
            btnAgendar.Location = new Point(343, 217);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(87, 29);
            btnAgendar.TabIndex = 3;
            btnAgendar.Text = "Aceptar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.TextChanged += btnAgendar_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(199, 217);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCantidadContactos
            // 
            lblCantidadContactos.AutoSize = true;
            lblCantidadContactos.Location = new Point(31, 426);
            lblCantidadContactos.Name = "lblCantidadContactos";
            lblCantidadContactos.Size = new Size(131, 15);
            lblCantidadContactos.TabIndex = 7;
            lblCantidadContactos.Text = "Cantidad de Contactos:";
            // 
            // lblFyH
            // 
            lblFyH.AutoSize = true;
            lblFyH.Location = new Point(612, 426);
            lblFyH.Name = "lblFyH";
            lblFyH.Size = new Size(76, 15);
            lblFyH.TabIndex = 8;
            lblFyH.Text = "Fecha y Hora";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(170, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(403, 29);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Gestion de Agenda de Contactos";
            // 
            // lstResultados
            // 
            lstResultados.DetectUrls = false;
            lstResultados.ForeColor = SystemColors.WindowText;
            lstResultados.Location = new Point(170, 280);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(318, 96);
            lstResultados.TabIndex = 5;
            lstResultados.Text = "";
            // 
            // frmAgendaContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblFyH);
            Controls.Add(lblCantidadContactos);
            Controls.Add(lstResultados);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgendar);
            Controls.Add(txtContacto);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Controls.Add(txtNumero);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAgendaContactos";
            Text = "1";
            Load += frmAgendaContactos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtNumero;
        private Label lblContacto;
        private Label lblNumero;
        private TextBox txtContacto;
        private Button btnAgendar;
        private Button btnCancelar;
        private Label lblCantidadContactos;
        private Label lblFyH;
        private Label lblTitulo;
        private RichTextBox lstResultados;
    }
}