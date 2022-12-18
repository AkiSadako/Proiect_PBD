namespace Proiect_PBD
{
    partial class Meniu
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
            this.btn_BD = new System.Windows.Forms.Button();
            this.btn_Afisare_nepromovati = new System.Windows.Forms.Button();
            this.btn_Raport_6 = new System.Windows.Forms.Button();
            this.btn_Raport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_golire_tabel = new System.Windows.Forms.Button();
            this.Adaugare_nota = new System.Windows.Forms.Button();
            this.btnPromovabilitate = new System.Windows.Forms.Button();
            this.btn_Prezentari_m = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BD
            // 
            this.btn_BD.Location = new System.Drawing.Point(12, 70);
            this.btn_BD.Name = "btn_BD";
            this.btn_BD.Size = new System.Drawing.Size(154, 46);
            this.btn_BD.TabIndex = 0;
            this.btn_BD.Text = "Introducere in BD";
            this.btn_BD.UseVisualStyleBackColor = true;
            this.btn_BD.Click += new System.EventHandler(this.btn_BD_Click);
            // 
            // btn_Afisare_nepromovati
            // 
            this.btn_Afisare_nepromovati.Location = new System.Drawing.Point(12, 157);
            this.btn_Afisare_nepromovati.Name = "btn_Afisare_nepromovati";
            this.btn_Afisare_nepromovati.Size = new System.Drawing.Size(154, 46);
            this.btn_Afisare_nepromovati.TabIndex = 1;
            this.btn_Afisare_nepromovati.Text = "Afisare studenti nepromovati";
            this.btn_Afisare_nepromovati.UseVisualStyleBackColor = true;
            this.btn_Afisare_nepromovati.Click += new System.EventHandler(this.btn_Afisare_nepromovati_Click);
            // 
            // btn_Raport_6
            // 
            this.btn_Raport_6.Location = new System.Drawing.Point(12, 325);
            this.btn_Raport_6.Name = "btn_Raport_6";
            this.btn_Raport_6.Size = new System.Drawing.Size(154, 46);
            this.btn_Raport_6.TabIndex = 2;
            this.btn_Raport_6.Text = "Generare raport (6)";
            this.btn_Raport_6.UseVisualStyleBackColor = true;
            this.btn_Raport_6.Click += new System.EventHandler(this.btn_Raport_6_Click);
            // 
            // btn_Raport
            // 
            this.btn_Raport.Location = new System.Drawing.Point(12, 244);
            this.btn_Raport.Name = "btn_Raport";
            this.btn_Raport.Size = new System.Drawing.Size(154, 46);
            this.btn_Raport.TabIndex = 3;
            this.btn_Raport.Text = "Generare raport(5)";
            this.btn_Raport.UseVisualStyleBackColor = true;
            this.btn_Raport.Click += new System.EventHandler(this.btn_Raport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(863, 577);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(439, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proiect PBD Nr. 10";
            // 
            // btn_golire_tabel
            // 
            this.btn_golire_tabel.Location = new System.Drawing.Point(943, 19);
            this.btn_golire_tabel.Name = "btn_golire_tabel";
            this.btn_golire_tabel.Size = new System.Drawing.Size(114, 37);
            this.btn_golire_tabel.TabIndex = 7;
            this.btn_golire_tabel.Text = "Golire tabel";
            this.btn_golire_tabel.UseVisualStyleBackColor = true;
            this.btn_golire_tabel.Click += new System.EventHandler(this.btn_golire_tabel_Click);
            // 
            // Adaugare_nota
            // 
            this.Adaugare_nota.Location = new System.Drawing.Point(12, 394);
            this.Adaugare_nota.Name = "Adaugare_nota";
            this.Adaugare_nota.Size = new System.Drawing.Size(154, 43);
            this.Adaugare_nota.TabIndex = 8;
            this.Adaugare_nota.Text = "Adaugare nota";
            this.Adaugare_nota.UseVisualStyleBackColor = true;
            this.Adaugare_nota.Click += new System.EventHandler(this.Adaugare_nota_Click);
            // 
            // btnPromovabilitate
            // 
            this.btnPromovabilitate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPromovabilitate.Location = new System.Drawing.Point(12, 476);
            this.btnPromovabilitate.Name = "btnPromovabilitate";
            this.btnPromovabilitate.Size = new System.Drawing.Size(154, 43);
            this.btnPromovabilitate.TabIndex = 10;
            this.btnPromovabilitate.Text = "Promovabiltatea";
            this.btnPromovabilitate.UseVisualStyleBackColor = true;
            this.btnPromovabilitate.Click += new System.EventHandler(this.btnPromovabilitate_Click);
            // 
            // btn_Prezentari_m
            // 
            this.btn_Prezentari_m.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Prezentari_m.Location = new System.Drawing.Point(12, 545);
            this.btn_Prezentari_m.Name = "btn_Prezentari_m";
            this.btn_Prezentari_m.Size = new System.Drawing.Size(154, 43);
            this.btn_Prezentari_m.TabIndex = 11;
            this.btn_Prezentari_m.Text = "Afisare prezentari";
            this.btn_Prezentari_m.UseVisualStyleBackColor = true;
            this.btn_Prezentari_m.Click += new System.EventHandler(this.btn_Prezentari_m_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 754);
            this.Controls.Add(this.btn_Prezentari_m);
            this.Controls.Add(this.btnPromovabilitate);
            this.Controls.Add(this.Adaugare_nota);
            this.Controls.Add(this.btn_golire_tabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Raport);
            this.Controls.Add(this.btn_Raport_6);
            this.Controls.Add(this.btn_Afisare_nepromovati);
            this.Controls.Add(this.btn_BD);
            this.Name = "Meniu";
            this.Text = "dss";
            this.Load += new System.EventHandler(this.Meniu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BD;
        private System.Windows.Forms.Button btn_Afisare_nepromovati;
        private System.Windows.Forms.Button btn_Raport_6;
        private System.Windows.Forms.Button btn_Raport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_golire_tabel;
        private System.Windows.Forms.Button Adaugare_nota;
        private System.Windows.Forms.Button btnPromovabilitate;
        private System.Windows.Forms.Button btn_Prezentari_m;
    }
}

