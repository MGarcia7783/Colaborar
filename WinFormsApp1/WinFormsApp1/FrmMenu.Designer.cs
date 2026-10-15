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
            btnCliente = new Button();
            btnUsuario = new Button();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.Font = new Font("Segoe UI", 12F);
            btnCliente.Location = new Point(31, 55);
            btnCliente.Margin = new Padding(3, 4, 3, 4);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(149, 77);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Font = new Font("Segoe UI", 12F);
            btnUsuario.Location = new Point(31, 167);
            btnUsuario.Margin = new Padding(3, 4, 3, 4);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(149, 77);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Usuarios";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnUsuario);
            Controls.Add(btnCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMenu";
            Text = "FrmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCliente;
        private Button btnUsuario;
    }
}