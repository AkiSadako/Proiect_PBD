namespace Proiect_PBD
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxlegitimatie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdaugare_nota = new System.Windows.Forms.Button();
            this.comboBoxdisciplina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adaugare nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selectati legitimatia studentului";
            // 
            // comboBoxlegitimatie
            // 
            this.comboBoxlegitimatie.FormattingEnabled = true;
            this.comboBoxlegitimatie.Location = new System.Drawing.Point(276, 90);
            this.comboBoxlegitimatie.Name = "comboBoxlegitimatie";
            this.comboBoxlegitimatie.Size = new System.Drawing.Size(234, 24);
            this.comboBoxlegitimatie.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Selectati anul\r\n";
            // 
            // comboBoxan
            // 
            this.comboBoxan.FormattingEnabled = true;
            this.comboBoxan.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxan.Location = new System.Drawing.Point(172, 203);
            this.comboBoxan.Name = "comboBoxan";
            this.comboBoxan.Size = new System.Drawing.Size(234, 24);
            this.comboBoxan.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Introduceti nota ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 22);
            this.textBox1.TabIndex = 13;
            // 
            // btnAdaugare_nota
            // 
            this.btnAdaugare_nota.Location = new System.Drawing.Point(191, 351);
            this.btnAdaugare_nota.Name = "btnAdaugare_nota";
            this.btnAdaugare_nota.Size = new System.Drawing.Size(130, 37);
            this.btnAdaugare_nota.TabIndex = 14;
            this.btnAdaugare_nota.Text = "Salvare";
            this.btnAdaugare_nota.UseVisualStyleBackColor = true;
            this.btnAdaugare_nota.Click += new System.EventHandler(this.btnAdaugare_nota_Click);
            // 
            // comboBoxdisciplina
            // 
            this.comboBoxdisciplina.FormattingEnabled = true;
            this.comboBoxdisciplina.Items.AddRange(new object[] {
            "Matematica",
            "Fizica",
            "Chimie",
            "Engleza"});
            this.comboBoxdisciplina.Location = new System.Drawing.Point(181, 153);
            this.comboBoxdisciplina.Name = "comboBoxdisciplina";
            this.comboBoxdisciplina.Size = new System.Drawing.Size(234, 24);
            this.comboBoxdisciplina.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Selectati disciplina\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 299);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 22);
            this.textBox2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nr Prezentare";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 423);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBoxdisciplina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdaugare_nota);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxlegitimatie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxlegitimatie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdaugare_nota;
        private System.Windows.Forms.ComboBox comboBoxdisciplina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}