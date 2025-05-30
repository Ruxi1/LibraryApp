namespace LibraryApp
{
    partial class Form1
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
            this.btnEligible = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnTitlu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 400);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnEligible
            // 
            this.btnEligible.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEligible.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEligible.ForeColor = System.Drawing.Color.Yellow;
            this.btnEligible.Location = new System.Drawing.Point(831, 176);
            this.btnEligible.Name = "btnEligible";
            this.btnEligible.Size = new System.Drawing.Size(115, 87);
            this.btnEligible.TabIndex = 11;
            this.btnEligible.Text = "Verificare eligibilitate imprumut";
            this.btnEligible.UseVisualStyleBackColor = false;
            this.btnEligible.Click += new System.EventHandler(this.btnEligible_Click_1);
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.Color.Chocolate;
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGen.Location = new System.Drawing.Point(521, 23);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(187, 30);
            this.btnGen.TabIndex = 10;
            this.btnGen.Text = "Alfabetic dupa gen";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.BackColor = System.Drawing.Color.Chocolate;
            this.btnAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAutor.Location = new System.Drawing.Point(316, 24);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(199, 29);
            this.btnAutor.TabIndex = 9;
            this.btnAutor.Text = "Alfabetic dupa autor";
            this.btnAutor.UseVisualStyleBackColor = false;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click_1);
            // 
            // btnTitlu
            // 
            this.btnTitlu.BackColor = System.Drawing.Color.Chocolate;
            this.btnTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitlu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTitlu.Location = new System.Drawing.Point(128, 24);
            this.btnTitlu.Name = "btnTitlu";
            this.btnTitlu.Size = new System.Drawing.Size(182, 29);
            this.btnTitlu.TabIndex = 8;
            this.btnTitlu.Text = "Alfabetic dupa titlu";
            this.btnTitlu.UseVisualStyleBackColor = false;
            this.btnTitlu.Click += new System.EventHandler(this.btnTitlu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista carti:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEligible);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.btnTitlu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEligible;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnTitlu;
        private System.Windows.Forms.Label label1;
    }
}

