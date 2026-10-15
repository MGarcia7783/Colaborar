namespace WinFormsApp1
{
    partial class FrmMenu
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
            this.btnCliente = new Button();
            btnUsuario = new Button();
            SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new Font("Segoe UI", 12F);
            this.btnCliente.Location = new Point(27, 41);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new Size(130, 58);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += this.btnCliente_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Font = new Font("Segoe UI", 12F);
            btnUsuario.Location = new Point(27, 125);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(130, 58);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Usuarios";
            btnUsuario.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUsuario);
            Controls.Add(this.btnCliente);
            Name = "FrmMenu";
            Text = "FrmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCliente;
        private Button btnUsuario;
    }
}