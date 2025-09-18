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
            btnVerContactos = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Enabled = false;
            txtNumero.Font = new Font("Segoe UI", 14.25F);
            txtNumero.Location = new Point(214, 177);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Mask = "(999)000-0000";
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(333, 39);
            txtNumero.TabIndex = 2;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 14.25F);
            lblContacto.Location = new Point(67, 105);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(110, 32);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 14.25F);
            lblNumero.Location = new Point(67, 188);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(102, 32);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Numero";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 14.25F);
            txtContacto.Location = new Point(214, 105);
            txtContacto.Margin = new Padding(3, 4, 3, 4);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(333, 39);
            txtContacto.TabIndex = 1;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // btnAgendar
            // 
            btnAgendar.Enabled = false;
            btnAgendar.Font = new Font("Segoe UI", 12F);
            btnAgendar.Location = new Point(496, 289);
            btnAgendar.Margin = new Padding(3, 4, 3, 4);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(113, 39);
            btnAgendar.TabIndex = 3;
            btnAgendar.Text = "Aceptar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(138, 289);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 39);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCantidadContactos
            // 
            lblCantidadContactos.AutoSize = true;
            lblCantidadContactos.Location = new Point(35, 568);
            lblCantidadContactos.Name = "lblCantidadContactos";
            lblCantidadContactos.Size = new Size(163, 20);
            lblCantidadContactos.TabIndex = 7;
            lblCantidadContactos.Text = "Cantidad de Contactos:";
            // 
            // lblFyH
            // 
            lblFyH.AutoSize = true;
            lblFyH.Location = new Point(699, 568);
            lblFyH.Name = "lblFyH";
            lblFyH.Size = new Size(95, 20);
            lblFyH.TabIndex = 8;
            lblFyH.Text = "Fecha y Hora";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(194, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(512, 36);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Gestion de Agenda de Contactos";
            // 
            // lstResultados
            // 
            lstResultados.DetectUrls = false;
            lstResultados.ForeColor = SystemColors.WindowText;
            lstResultados.Location = new Point(194, 373);
            lstResultados.Margin = new Padding(3, 4, 3, 4);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(363, 127);
            lstResultados.TabIndex = 5;
            lstResultados.Text = "";
            // 
            // btnVerContactos
            // 
            btnVerContactos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerContactos.Location = new Point(284, 291);
            btnVerContactos.Margin = new Padding(3, 4, 3, 4);
            btnVerContactos.Name = "btnVerContactos";
            btnVerContactos.Size = new Size(165, 39);
            btnVerContactos.TabIndex = 10;
            btnVerContactos.Text = "Ver Contactos";
            btnVerContactos.UseVisualStyleBackColor = true;
            btnVerContactos.Click += btnVerContactos_Click;
            // 
            // frmAgendaContactos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnVerContactos);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnVerContactos;
    }
}