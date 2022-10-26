namespace CrucerosOnderForms
{
    partial class FormLogIn
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
            this.LogInButton = new System.Windows.Forms.Button();
            this.ingresoNombre = new System.Windows.Forms.TextBox();
            this.ingresoPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.LogInButton.Location = new System.Drawing.Point(32, 118);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(137, 29);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.Text = "Ingresar";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ingresoNombre
            // 
            this.ingresoNombre.Location = new System.Drawing.Point(32, 23);
            this.ingresoNombre.Name = "ingresoNombre";
            this.ingresoNombre.PlaceholderText = "Nombre de Usuario";
            this.ingresoNombre.Size = new System.Drawing.Size(137, 27);
            this.ingresoNombre.TabIndex = 1;
            // 
            // ingresoPassword
            // 
            this.ingresoPassword.Location = new System.Drawing.Point(32, 66);
            this.ingresoPassword.Name = "ingresoPassword";
            this.ingresoPassword.PasswordChar = '*';
            this.ingresoPassword.PlaceholderText = "Contraseña";
            this.ingresoPassword.Size = new System.Drawing.Size(137, 27);
            this.ingresoPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "CRUCEROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(210, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "ONDER";
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(392, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingresoPassword);
            this.Controls.Add(this.ingresoNombre);
            this.Controls.Add(this.LogInButton);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TextBox ingresoNombre;
        private System.Windows.Forms.TextBox ingresoPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}