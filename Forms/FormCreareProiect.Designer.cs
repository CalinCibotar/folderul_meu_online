namespace AgendaActivitati.Forms
{
    partial class FormCreareProiect
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.dtpInceput = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalizare = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creare Proiect nou";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denumire Proiect";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de inceput";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de finalizare";
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(272, 540);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(200, 60);
            this.btnSalvare.TabIndex = 4;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(272, 606);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(200, 60);
            this.btnAnulare.TabIndex = 5;
            this.btnAnulare.Text = "Anuleaza";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(272, 253);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(264, 31);
            this.txtDenumire.TabIndex = 6;
            // 
            // dtpInceput
            // 
            this.dtpInceput.Location = new System.Drawing.Point(272, 363);
            this.dtpInceput.Name = "dtpInceput";
            this.dtpInceput.Size = new System.Drawing.Size(264, 31);
            this.dtpInceput.TabIndex = 7;
            // 
            // dtpFinalizare
            // 
            this.dtpFinalizare.Location = new System.Drawing.Point(272, 474);
            this.dtpFinalizare.Name = "dtpFinalizare";
            this.dtpFinalizare.Size = new System.Drawing.Size(264, 31);
            this.dtpFinalizare.TabIndex = 8;
            // 
            // FormCreareProiect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 929);
            this.Controls.Add(this.dtpFinalizare);
            this.Controls.Add(this.dtpInceput);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreareProiect";
            this.Text = "FormCreareProiect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.DateTimePicker dtpInceput;
        private System.Windows.Forms.DateTimePicker dtpFinalizare;
    }
}