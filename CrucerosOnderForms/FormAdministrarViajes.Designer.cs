namespace CrucerosOnderForms
{
    partial class FormAdministrarViajes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_VolverAdmV = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AñadirPasajeroAdmV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(677, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_VolverAdmV
            // 
            this.btn_VolverAdmV.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_VolverAdmV.Location = new System.Drawing.Point(524, 266);
            this.btn_VolverAdmV.Name = "btn_VolverAdmV";
            this.btn_VolverAdmV.Size = new System.Drawing.Size(297, 75);
            this.btn_VolverAdmV.TabIndex = 1;
            this.btn_VolverAdmV.Text = "Volver";
            this.btn_VolverAdmV.UseVisualStyleBackColor = false;
            this.btn_VolverAdmV.Click += new System.EventHandler(this.btn_VolverAdmV_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.Dni,
            this.Pasaporte,
            this.Clase});
            this.dataGridView2.Location = new System.Drawing.Point(702, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(541, 172);
            this.dataGridView2.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 125;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.MinimumWidth = 6;
            this.Dni.Name = "Dni";
            this.Dni.Width = 125;
            // 
            // Pasaporte
            // 
            this.Pasaporte.HeaderText = "Pasaporte";
            this.Pasaporte.MinimumWidth = 6;
            this.Pasaporte.Name = "Pasaporte";
            this.Pasaporte.Width = 125;
            // 
            // Clase
            // 
            this.Clase.HeaderText = "Clase";
            this.Clase.MinimumWidth = 6;
            this.Clase.Name = "Clase";
            this.Clase.Width = 125;
            // 
            // btn_AñadirPasajeroAdmV
            // 
            this.btn_AñadirPasajeroAdmV.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_AñadirPasajeroAdmV.Location = new System.Drawing.Point(19, 219);
            this.btn_AñadirPasajeroAdmV.Name = "btn_AñadirPasajeroAdmV";
            this.btn_AñadirPasajeroAdmV.Size = new System.Drawing.Size(188, 65);
            this.btn_AñadirPasajeroAdmV.TabIndex = 4;
            this.btn_AñadirPasajeroAdmV.Text = "Añadir Pasajero";
            this.btn_AñadirPasajeroAdmV.UseVisualStyleBackColor = false;
            this.btn_AñadirPasajeroAdmV.Click += new System.EventHandler(this.btn_AñadirPasajeroAdmV_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Location = new System.Drawing.Point(1140, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = false;

            // 
            // FormAdministrarViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1269, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AñadirPasajeroAdmV);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_VolverAdmV);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAdministrarViajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdministrarViajes";
            this.Load += new System.EventHandler(this.FormAdministrarViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_VolverAdmV;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clase;
        private System.Windows.Forms.Button btn_AñadirPasajeroAdmV;
        private System.Windows.Forms.Button button1;
    }
}