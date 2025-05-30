namespace AgendaActivitati.Forms
{
    partial class FormCreareActivitate
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
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.dtpInceput = new System.Windows.Forms.DateTimePicker();
            this.nudDurata = new System.Windows.Forms.NumericUpDown();
            this.cbProiect = new System.Windows.Forms.ComboBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEtapa = new System.Windows.Forms.TextBox();
            this.btnAdaugaEtapa = new System.Windows.Forms.Button();
            this.btnStergeEtapa = new System.Windows.Forms.Button();
            this.lstEtape = new System.Windows.Forms.ListBox();
            this.clbResurseDisponibile = new System.Windows.Forms.CheckedListBox();
            this.btnAdaugaResurse = new System.Windows.Forms.Button();
            this.btnStergeResurse = new System.Windows.Forms.Button();
            this.lstResurseAsociate = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDomeniu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de inceput";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proiect asociat";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(247, 181);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(244, 31);
            this.txtDenumire.TabIndex = 6;
            // 
            // dtpInceput
            // 
            this.dtpInceput.Location = new System.Drawing.Point(247, 352);
            this.dtpInceput.Name = "dtpInceput";
            this.dtpInceput.Size = new System.Drawing.Size(243, 31);
            this.dtpInceput.TabIndex = 7;
            // 
            // nudDurata
            // 
            this.nudDurata.Location = new System.Drawing.Point(246, 452);
            this.nudDurata.Name = "nudDurata";
            this.nudDurata.Size = new System.Drawing.Size(244, 31);
            this.nudDurata.TabIndex = 8;
            // 
            // cbProiect
            // 
            this.cbProiect.FormattingEnabled = true;
            this.cbProiect.Location = new System.Drawing.Point(246, 565);
            this.cbProiect.Name = "cbProiect";
            this.cbProiect.Size = new System.Drawing.Size(244, 33);
            this.cbProiect.TabIndex = 9;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(246, 625);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(200, 60);
            this.btnSalvare.TabIndex = 10;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(246, 691);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(200, 60);
            this.btnAnulare.TabIndex = 11;
            this.btnAnulare.Text = "Anuleaza";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Creare Activitate noua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Etape:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Adauga Etapa";
            // 
            // txtEtapa
            // 
            this.txtEtapa.Location = new System.Drawing.Point(572, 565);
            this.txtEtapa.Name = "txtEtapa";
            this.txtEtapa.Size = new System.Drawing.Size(456, 31);
            this.txtEtapa.TabIndex = 16;
            // 
            // btnAdaugaEtapa
            // 
            this.btnAdaugaEtapa.Location = new System.Drawing.Point(572, 625);
            this.btnAdaugaEtapa.Name = "btnAdaugaEtapa";
            this.btnAdaugaEtapa.Size = new System.Drawing.Size(200, 60);
            this.btnAdaugaEtapa.TabIndex = 17;
            this.btnAdaugaEtapa.Text = "Adauga Etapa";
            this.btnAdaugaEtapa.UseVisualStyleBackColor = true;
            this.btnAdaugaEtapa.Click += new System.EventHandler(this.btnAdaugaEtapa_Click);
            // 
            // btnStergeEtapa
            // 
            this.btnStergeEtapa.Location = new System.Drawing.Point(572, 691);
            this.btnStergeEtapa.Name = "btnStergeEtapa";
            this.btnStergeEtapa.Size = new System.Drawing.Size(200, 60);
            this.btnStergeEtapa.TabIndex = 18;
            this.btnStergeEtapa.Text = "Sterge";
            this.btnStergeEtapa.UseVisualStyleBackColor = true;
            this.btnStergeEtapa.Click += new System.EventHandler(this.btnStergeEtapa_Click);
            // 
            // lstEtape
            // 
            this.lstEtape.FormattingEnabled = true;
            this.lstEtape.ItemHeight = 25;
            this.lstEtape.Location = new System.Drawing.Point(563, 181);
            this.lstEtape.Name = "lstEtape";
            this.lstEtape.Size = new System.Drawing.Size(470, 304);
            this.lstEtape.TabIndex = 19;
            // 
            // clbResurseDisponibile
            // 
            this.clbResurseDisponibile.FormattingEnabled = true;
            this.clbResurseDisponibile.Location = new System.Drawing.Point(1066, 183);
            this.clbResurseDisponibile.Name = "clbResurseDisponibile";
            this.clbResurseDisponibile.Size = new System.Drawing.Size(470, 200);
            this.clbResurseDisponibile.TabIndex = 20;
            // 
            // btnAdaugaResurse
            // 
            this.btnAdaugaResurse.Location = new System.Drawing.Point(1066, 625);
            this.btnAdaugaResurse.Name = "btnAdaugaResurse";
            this.btnAdaugaResurse.Size = new System.Drawing.Size(200, 60);
            this.btnAdaugaResurse.TabIndex = 21;
            this.btnAdaugaResurse.Text = "Adauga Resurse";
            this.btnAdaugaResurse.UseVisualStyleBackColor = true;
            this.btnAdaugaResurse.Click += new System.EventHandler(this.btnAdaugaResurse_Click);
            // 
            // btnStergeResurse
            // 
            this.btnStergeResurse.Location = new System.Drawing.Point(1066, 691);
            this.btnStergeResurse.Name = "btnStergeResurse";
            this.btnStergeResurse.Size = new System.Drawing.Size(200, 60);
            this.btnStergeResurse.TabIndex = 22;
            this.btnStergeResurse.Text = "Sterge Resurse";
            this.btnStergeResurse.UseVisualStyleBackColor = true;
            this.btnStergeResurse.Click += new System.EventHandler(this.btnStergeResurse_Click);
            // 
            // lstResurseAsociate
            // 
            this.lstResurseAsociate.FormattingEnabled = true;
            this.lstResurseAsociate.ItemHeight = 25;
            this.lstResurseAsociate.Location = new System.Drawing.Point(1066, 395);
            this.lstResurseAsociate.Name = "lstResurseAsociate";
            this.lstResurseAsociate.Size = new System.Drawing.Size(470, 204);
            this.lstResurseAsociate.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Domeniu";
            // 
            // cbDomeniu
            // 
            this.cbDomeniu.FormattingEnabled = true;
            this.cbDomeniu.Location = new System.Drawing.Point(246, 258);
            this.cbDomeniu.Name = "cbDomeniu";
            this.cbDomeniu.Size = new System.Drawing.Size(244, 33);
            this.cbDomeniu.TabIndex = 25;
            // 
            // FormCreareActivitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.cbDomeniu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstResurseAsociate);
            this.Controls.Add(this.btnStergeResurse);
            this.Controls.Add(this.btnAdaugaResurse);
            this.Controls.Add(this.clbResurseDisponibile);
            this.Controls.Add(this.lstEtape);
            this.Controls.Add(this.btnStergeEtapa);
            this.Controls.Add(this.btnAdaugaEtapa);
            this.Controls.Add(this.txtEtapa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.cbProiect);
            this.Controls.Add(this.nudDurata);
            this.Controls.Add(this.dtpInceput);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreareActivitate";
            this.Text = "FormCreareActivitate";
            ((System.ComponentModel.ISupportInitialize)(this.nudDurata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.DateTimePicker dtpInceput;
        private System.Windows.Forms.NumericUpDown nudDurata;
        private System.Windows.Forms.ComboBox cbProiect;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEtapa;
        private System.Windows.Forms.Button btnAdaugaEtapa;
        private System.Windows.Forms.Button btnStergeEtapa;
        private System.Windows.Forms.ListBox lstEtape;
        private System.Windows.Forms.CheckedListBox clbResurseDisponibile;
        private System.Windows.Forms.Button btnAdaugaResurse;
        private System.Windows.Forms.Button btnStergeResurse;
        private System.Windows.Forms.ListBox lstResurseAsociate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDomeniu;
    }
}