namespace CrucerosOnderForms
{
    partial class FormMostrarPasajeros
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
            this.btn_VolverMosPas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(760, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_VolverMosPas
            // 
            this.btn_VolverMosPas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_VolverMosPas.Location = new System.Drawing.Point(309, 409);
            this.btn_VolverMosPas.Name = "btn_VolverMosPas";
            this.btn_VolverMosPas.Size = new System.Drawing.Size(153, 29);
            this.btn_VolverMosPas.TabIndex = 1;
            this.btn_VolverMosPas.Text = "Volver";
            this.btn_VolverMosPas.UseVisualStyleBackColor = false;
            this.btn_VolverMosPas.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMostrarPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_VolverMosPas);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMostrarPasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMostrarPasajeros";
            this.Load += new System.EventHandler(this.FormMostrarPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_VolverMosPas;
    }
}