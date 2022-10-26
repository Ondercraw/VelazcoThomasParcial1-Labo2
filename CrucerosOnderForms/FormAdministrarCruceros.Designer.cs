namespace CrucerosOnderForms
{
    partial class FormAdministrarCruceros
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
            this.tb_NombreCrucero = new System.Windows.Forms.TextBox();
            this.tb_MatriculaCrucero = new System.Windows.Forms.TextBox();
            this.tb_CantidadSalonesCrucero = new System.Windows.Forms.TextBox();
            this.tb_CantidadCasinosCrucero = new System.Windows.Forms.TextBox();
            this.tb_CantidadCamarotesCrucero = new System.Windows.Forms.TextBox();
            this.btn_AgregarCruceros = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ExtraRegional1 = new System.Windows.Forms.RadioButton();
            this.rb_Regional = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rb_ExtraRegional2 = new System.Windows.Forms.RadioButton();
            this.rb_Regional2 = new System.Windows.Forms.RadioButton();
            this.btn_VolverAdmC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_NombreCrucero
            // 
            this.tb_NombreCrucero.Location = new System.Drawing.Point(33, 27);
            this.tb_NombreCrucero.Name = "tb_NombreCrucero";
            this.tb_NombreCrucero.PlaceholderText = "Nombre";
            this.tb_NombreCrucero.Size = new System.Drawing.Size(238, 27);
            this.tb_NombreCrucero.TabIndex = 0;
            // 
            // tb_MatriculaCrucero
            // 
            this.tb_MatriculaCrucero.Location = new System.Drawing.Point(33, 72);
            this.tb_MatriculaCrucero.Name = "tb_MatriculaCrucero";
            this.tb_MatriculaCrucero.PlaceholderText = "Matricula";
            this.tb_MatriculaCrucero.Size = new System.Drawing.Size(238, 27);
            this.tb_MatriculaCrucero.TabIndex = 1;
            // 
            // tb_CantidadSalonesCrucero
            // 
            this.tb_CantidadSalonesCrucero.Location = new System.Drawing.Point(33, 119);
            this.tb_CantidadSalonesCrucero.Name = "tb_CantidadSalonesCrucero";
            this.tb_CantidadSalonesCrucero.PlaceholderText = "Cantidad de Salones";
            this.tb_CantidadSalonesCrucero.Size = new System.Drawing.Size(238, 27);
            this.tb_CantidadSalonesCrucero.TabIndex = 2;
            // 
            // tb_CantidadCasinosCrucero
            // 
            this.tb_CantidadCasinosCrucero.Location = new System.Drawing.Point(34, 170);
            this.tb_CantidadCasinosCrucero.Name = "tb_CantidadCasinosCrucero";
            this.tb_CantidadCasinosCrucero.PlaceholderText = "Cantidad de Casinos";
            this.tb_CantidadCasinosCrucero.Size = new System.Drawing.Size(237, 27);
            this.tb_CantidadCasinosCrucero.TabIndex = 3;
            // 
            // tb_CantidadCamarotesCrucero
            // 
            this.tb_CantidadCamarotesCrucero.Location = new System.Drawing.Point(33, 215);
            this.tb_CantidadCamarotesCrucero.Name = "tb_CantidadCamarotesCrucero";
            this.tb_CantidadCamarotesCrucero.PlaceholderText = "Cantidad de Camarotes";
            this.tb_CantidadCamarotesCrucero.Size = new System.Drawing.Size(238, 27);
            this.tb_CantidadCamarotesCrucero.TabIndex = 4;
            // 
            // btn_AgregarCruceros
            // 
            this.btn_AgregarCruceros.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_AgregarCruceros.Location = new System.Drawing.Point(35, 268);
            this.btn_AgregarCruceros.Name = "btn_AgregarCruceros";
            this.btn_AgregarCruceros.Size = new System.Drawing.Size(106, 44);
            this.btn_AgregarCruceros.TabIndex = 5;
            this.btn_AgregarCruceros.Text = "Añadir";
            this.btn_AgregarCruceros.UseVisualStyleBackColor = false;
            this.btn_AgregarCruceros.Click += new System.EventHandler(this.btn_AgregarCruceros_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_ExtraRegional1);
            this.groupBox1.Controls.Add(this.rb_Regional);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(296, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 141);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partida";
            // 
            // rb_ExtraRegional1
            // 
            this.rb_ExtraRegional1.AutoSize = true;
            this.rb_ExtraRegional1.Location = new System.Drawing.Point(22, 74);
            this.rb_ExtraRegional1.Name = "rb_ExtraRegional1";
            this.rb_ExtraRegional1.Size = new System.Drawing.Size(126, 24);
            this.rb_ExtraRegional1.TabIndex = 1;
            this.rb_ExtraRegional1.TabStop = true;
            this.rb_ExtraRegional1.Text = "Extra Regional";
            this.rb_ExtraRegional1.UseVisualStyleBackColor = true;
            this.rb_ExtraRegional1.CheckedChanged += new System.EventHandler(this.rb_ExtraRegional1_CheckedChanged);
            // 
            // rb_Regional
            // 
            this.rb_Regional.AutoSize = true;
            this.rb_Regional.Location = new System.Drawing.Point(22, 35);
            this.rb_Regional.Name = "rb_Regional";
            this.rb_Regional.Size = new System.Drawing.Size(89, 24);
            this.rb_Regional.TabIndex = 0;
            this.rb_Regional.TabStop = true;
            this.rb_Regional.Text = "Regional";
            this.rb_Regional.UseVisualStyleBackColor = true;
            this.rb_Regional.CheckedChanged += new System.EventHandler(this.rb_Regional_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.rb_ExtraRegional2);
            this.groupBox2.Controls.Add(this.rb_Regional2);
            this.groupBox2.Location = new System.Drawing.Point(296, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 162);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(22, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 9;
            // 
            // rb_ExtraRegional2
            // 
            this.rb_ExtraRegional2.AutoSize = true;
            this.rb_ExtraRegional2.Location = new System.Drawing.Point(22, 83);
            this.rb_ExtraRegional2.Name = "rb_ExtraRegional2";
            this.rb_ExtraRegional2.Size = new System.Drawing.Size(126, 24);
            this.rb_ExtraRegional2.TabIndex = 1;
            this.rb_ExtraRegional2.TabStop = true;
            this.rb_ExtraRegional2.Text = "Extra Regional";
            this.rb_ExtraRegional2.UseVisualStyleBackColor = true;
            this.rb_ExtraRegional2.CheckedChanged += new System.EventHandler(this.rb_ExtraRegional2_CheckedChanged);
            // 
            // rb_Regional2
            // 
            this.rb_Regional2.AutoSize = true;
            this.rb_Regional2.Location = new System.Drawing.Point(22, 47);
            this.rb_Regional2.Name = "rb_Regional2";
            this.rb_Regional2.Size = new System.Drawing.Size(89, 24);
            this.rb_Regional2.TabIndex = 0;
            this.rb_Regional2.TabStop = true;
            this.rb_Regional2.Text = "Regional";
            this.rb_Regional2.UseVisualStyleBackColor = true;
            this.rb_Regional2.CheckedChanged += new System.EventHandler(this.rb_Regional2_CheckedChanged);
            // 
            // btn_VolverAdmC
            // 
            this.btn_VolverAdmC.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_VolverAdmC.Location = new System.Drawing.Point(165, 268);
            this.btn_VolverAdmC.Name = "btn_VolverAdmC";
            this.btn_VolverAdmC.Size = new System.Drawing.Size(106, 44);
            this.btn_VolverAdmC.TabIndex = 9;
            this.btn_VolverAdmC.Text = "Volver";
            this.btn_VolverAdmC.UseVisualStyleBackColor = false;
            this.btn_VolverAdmC.Click += new System.EventHandler(this.btn_VolverAdmC_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Location = new System.Drawing.Point(538, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdministrarCruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(653, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_VolverAdmC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_AgregarCruceros);
            this.Controls.Add(this.tb_CantidadCamarotesCrucero);
            this.Controls.Add(this.tb_CantidadCasinosCrucero);
            this.Controls.Add(this.tb_CantidadSalonesCrucero);
            this.Controls.Add(this.tb_MatriculaCrucero);
            this.Controls.Add(this.tb_NombreCrucero);
            this.Name = "FormAdministrarCruceros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdministrarCruceros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NombreCrucero;
        private System.Windows.Forms.TextBox tb_MatriculaCrucero;
        private System.Windows.Forms.TextBox tb_CantidadSalonesCrucero;
        private System.Windows.Forms.TextBox tb_CantidadCasinosCrucero;
        private System.Windows.Forms.TextBox tb_CantidadCamarotesCrucero;
        private System.Windows.Forms.Button btn_AgregarCruceros;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_ExtraRegional1;
        private System.Windows.Forms.RadioButton rb_Regional;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton rb_ExtraRegional2;
        private System.Windows.Forms.RadioButton rb_Regional2;
        private System.Windows.Forms.Button btn_VolverAdmC;
        private System.Windows.Forms.Button button1;
    }
}