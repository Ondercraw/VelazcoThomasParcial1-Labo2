namespace CrucerosOnderForms
{
    partial class FormVentas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_ClaseIndv = new System.Windows.Forms.ComboBox();
            this.tb_PasaporteIndv = new System.Windows.Forms.TextBox();
            this.tb_DniIndv = new System.Windows.Forms.TextBox();
            this.tb_EdadIndv = new System.Windows.Forms.TextBox();
            this.tb_ApellidoIndv = new System.Windows.Forms.TextBox();
            this.tb_NombreIndv = new System.Windows.Forms.TextBox();
            this.btn_IndividualFrmV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_ClaseFam = new System.Windows.Forms.ComboBox();
            this.tb_PasaporteFam = new System.Windows.Forms.TextBox();
            this.tb_DniFam = new System.Windows.Forms.TextBox();
            this.tb_EdadFam = new System.Windows.Forms.TextBox();
            this.tb_ApellidoFam = new System.Windows.Forms.TextBox();
            this.btn_GrupoFamiliarFrmV = new System.Windows.Forms.Button();
            this.btn_Añadir = new System.Windows.Forms.Button();
            this.btn_VolverVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_ClaseIndv);
            this.groupBox1.Controls.Add(this.tb_PasaporteIndv);
            this.groupBox1.Controls.Add(this.tb_DniIndv);
            this.groupBox1.Controls.Add(this.tb_EdadIndv);
            this.groupBox1.Controls.Add(this.tb_ApellidoIndv);
            this.groupBox1.Controls.Add(this.tb_NombreIndv);
            this.groupBox1.Location = new System.Drawing.Point(49, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Individual";
            // 
            // cb_ClaseIndv
            // 
            this.cb_ClaseIndv.FormattingEnabled = true;
            this.cb_ClaseIndv.Items.AddRange(new object[] {
            "Clase media",
            "Premium"});
            this.cb_ClaseIndv.Location = new System.Drawing.Point(9, 191);
            this.cb_ClaseIndv.Name = "cb_ClaseIndv";
            this.cb_ClaseIndv.Size = new System.Drawing.Size(125, 28);
            this.cb_ClaseIndv.TabIndex = 5;
            this.cb_ClaseIndv.Text = "Clase";
            // 
            // tb_PasaporteIndv
            // 
            this.tb_PasaporteIndv.Location = new System.Drawing.Point(9, 158);
            this.tb_PasaporteIndv.Name = "tb_PasaporteIndv";
            this.tb_PasaporteIndv.PlaceholderText = "Pasaporte";
            this.tb_PasaporteIndv.Size = new System.Drawing.Size(125, 27);
            this.tb_PasaporteIndv.TabIndex = 4;
            // 
            // tb_DniIndv
            // 
            this.tb_DniIndv.Location = new System.Drawing.Point(9, 125);
            this.tb_DniIndv.Name = "tb_DniIndv";
            this.tb_DniIndv.PlaceholderText = "Dni";
            this.tb_DniIndv.Size = new System.Drawing.Size(125, 27);
            this.tb_DniIndv.TabIndex = 3;
            // 
            // tb_EdadIndv
            // 
            this.tb_EdadIndv.Location = new System.Drawing.Point(9, 92);
            this.tb_EdadIndv.Name = "tb_EdadIndv";
            this.tb_EdadIndv.PlaceholderText = "Edad";
            this.tb_EdadIndv.Size = new System.Drawing.Size(125, 27);
            this.tb_EdadIndv.TabIndex = 2;
            // 
            // tb_ApellidoIndv
            // 
            this.tb_ApellidoIndv.Location = new System.Drawing.Point(9, 59);
            this.tb_ApellidoIndv.Name = "tb_ApellidoIndv";
            this.tb_ApellidoIndv.PlaceholderText = "Apellido";
            this.tb_ApellidoIndv.Size = new System.Drawing.Size(125, 27);
            this.tb_ApellidoIndv.TabIndex = 1;
            // 
            // tb_NombreIndv
            // 
            this.tb_NombreIndv.Location = new System.Drawing.Point(9, 26);
            this.tb_NombreIndv.Name = "tb_NombreIndv";
            this.tb_NombreIndv.PlaceholderText = "Nombre";
            this.tb_NombreIndv.Size = new System.Drawing.Size(125, 27);
            this.tb_NombreIndv.TabIndex = 0;
            // 
            // btn_IndividualFrmV
            // 
            this.btn_IndividualFrmV.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_IndividualFrmV.Location = new System.Drawing.Point(21, 246);
            this.btn_IndividualFrmV.Name = "btn_IndividualFrmV";
            this.btn_IndividualFrmV.Size = new System.Drawing.Size(199, 115);
            this.btn_IndividualFrmV.TabIndex = 6;
            this.btn_IndividualFrmV.Text = "Individual";
            this.btn_IndividualFrmV.UseVisualStyleBackColor = false;
            this.btn_IndividualFrmV.Click += new System.EventHandler(this.btn_IndividualFrmV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_ClaseFam);
            this.groupBox2.Controls.Add(this.tb_PasaporteFam);
            this.groupBox2.Controls.Add(this.tb_DniFam);
            this.groupBox2.Controls.Add(this.tb_EdadFam);
            this.groupBox2.Controls.Add(this.tb_ApellidoFam);
            this.groupBox2.Location = new System.Drawing.Point(725, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupo Familiar";
            // 
            // cb_ClaseFam
            // 
            this.cb_ClaseFam.FormattingEnabled = true;
            this.cb_ClaseFam.Items.AddRange(new object[] {
            "Clase Media",
            "Premium"});
            this.cb_ClaseFam.Location = new System.Drawing.Point(6, 158);
            this.cb_ClaseFam.Name = "cb_ClaseFam";
            this.cb_ClaseFam.Size = new System.Drawing.Size(125, 28);
            this.cb_ClaseFam.TabIndex = 4;
            this.cb_ClaseFam.Text = "Clase";
            // 
            // tb_PasaporteFam
            // 
            this.tb_PasaporteFam.Location = new System.Drawing.Point(6, 125);
            this.tb_PasaporteFam.Name = "tb_PasaporteFam";
            this.tb_PasaporteFam.PlaceholderText = "Pasaporte";
            this.tb_PasaporteFam.Size = new System.Drawing.Size(125, 27);
            this.tb_PasaporteFam.TabIndex = 3;
            // 
            // tb_DniFam
            // 
            this.tb_DniFam.Location = new System.Drawing.Point(6, 92);
            this.tb_DniFam.Name = "tb_DniFam";
            this.tb_DniFam.PlaceholderText = "Dni";
            this.tb_DniFam.Size = new System.Drawing.Size(125, 27);
            this.tb_DniFam.TabIndex = 2;
            // 
            // tb_EdadFam
            // 
            this.tb_EdadFam.Location = new System.Drawing.Point(6, 59);
            this.tb_EdadFam.Name = "tb_EdadFam";
            this.tb_EdadFam.PlaceholderText = "Edad";
            this.tb_EdadFam.Size = new System.Drawing.Size(125, 27);
            this.tb_EdadFam.TabIndex = 1;
            // 
            // tb_ApellidoFam
            // 
            this.tb_ApellidoFam.Location = new System.Drawing.Point(6, 26);
            this.tb_ApellidoFam.Name = "tb_ApellidoFam";
            this.tb_ApellidoFam.PlaceholderText = "Apellido";
            this.tb_ApellidoFam.Size = new System.Drawing.Size(125, 27);
            this.tb_ApellidoFam.TabIndex = 0;
            // 
            // btn_GrupoFamiliarFrmV
            // 
            this.btn_GrupoFamiliarFrmV.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_GrupoFamiliarFrmV.Location = new System.Drawing.Point(697, 246);
            this.btn_GrupoFamiliarFrmV.Name = "btn_GrupoFamiliarFrmV";
            this.btn_GrupoFamiliarFrmV.Size = new System.Drawing.Size(199, 115);
            this.btn_GrupoFamiliarFrmV.TabIndex = 5;
            this.btn_GrupoFamiliarFrmV.Text = "Grupo Familiar";
            this.btn_GrupoFamiliarFrmV.UseVisualStyleBackColor = false;
            this.btn_GrupoFamiliarFrmV.Click += new System.EventHandler(this.btn_GrupoFamiliarFrmV_Click);
            // 
            // btn_Añadir
            // 
            this.btn_Añadir.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Añadir.Location = new System.Drawing.Point(314, 435);
            this.btn_Añadir.Name = "btn_Añadir";
            this.btn_Añadir.Size = new System.Drawing.Size(111, 60);
            this.btn_Añadir.TabIndex = 6;
            this.btn_Añadir.Text = "Añadir";
            this.btn_Añadir.UseVisualStyleBackColor = false;
            this.btn_Añadir.Click += new System.EventHandler(this.btn_Añadir_Click);
            // 
            // btn_VolverVentas
            // 
            this.btn_VolverVentas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_VolverVentas.Location = new System.Drawing.Point(517, 435);
            this.btn_VolverVentas.Name = "btn_VolverVentas";
            this.btn_VolverVentas.Size = new System.Drawing.Size(111, 60);
            this.btn_VolverVentas.TabIndex = 7;
            this.btn_VolverVentas.Text = "Volver";
            this.btn_VolverVentas.UseVisualStyleBackColor = false;
            this.btn_VolverVentas.Click += new System.EventHandler(this.btn_VolverVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(365, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "CRUCEROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(314, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 85);
            this.label2.TabIndex = 9;
            this.label2.Text = "ONDER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Location = new System.Drawing.Point(778, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(908, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VolverVentas);
            this.Controls.Add(this.btn_GrupoFamiliarFrmV);
            this.Controls.Add(this.btn_IndividualFrmV);
            this.Controls.Add(this.btn_Añadir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_EdadIndv;
        private System.Windows.Forms.TextBox tb_ApellidoIndv;
        private System.Windows.Forms.TextBox tb_NombreIndv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_PasaporteIndv;
        private System.Windows.Forms.TextBox tb_DniIndv;
        private System.Windows.Forms.ComboBox cb_ClaseIndv;
        private System.Windows.Forms.Button btn_Añadir;
        private System.Windows.Forms.ComboBox cb_ClaseFam;
        private System.Windows.Forms.TextBox tb_PasaporteFam;
        private System.Windows.Forms.TextBox tb_DniFam;
        private System.Windows.Forms.TextBox tb_EdadFam;
        private System.Windows.Forms.TextBox tb_ApellidoFam;
        private System.Windows.Forms.Button btn_IndividualFrmV;
        private System.Windows.Forms.Button btn_GrupoFamiliarFrmV;
        private System.Windows.Forms.Button btn_VolverVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}