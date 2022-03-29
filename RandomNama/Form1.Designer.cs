
namespace RandomNama
{
    partial class RandomNama
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
            this.Random = new System.Windows.Forms.Button();
            this.dgvNama = new System.Windows.Forms.DataGridView();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelCustID = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNama)).BeginInit();
            this.SuspendLayout();
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(85, 68);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(75, 23);
            this.Random.TabIndex = 0;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // dgvNama
            // 
            this.dgvNama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNama.Location = new System.Drawing.Point(85, 156);
            this.dgvNama.Name = "dgvNama";
            this.dgvNama.Size = new System.Drawing.Size(546, 258);
            this.dgvNama.TabIndex = 1;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(338, 77);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "label1";
            // 
            // labelCustID
            // 
            this.labelCustID.AutoSize = true;
            this.labelCustID.Location = new System.Drawing.Point(341, 42);
            this.labelCustID.Name = "labelCustID";
            this.labelCustID.Size = new System.Drawing.Size(35, 13);
            this.labelCustID.TabIndex = 3;
            this.labelCustID.Text = "label1";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(341, 111);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(35, 13);
            this.labelAdress.TabIndex = 4;
            this.labelAdress.Text = "label1";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(583, 77);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // RandomNama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelCustID);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.dgvNama);
            this.Controls.Add(this.Random);
            this.Name = "RandomNama";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.DataGridView dgvNama;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelCustID;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Button buttonInsert;
    }
}

