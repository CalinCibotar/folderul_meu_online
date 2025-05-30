namespace AgendaActivitati.Forms
{
    partial class FormCreareResursa
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
            this.rbPersoana = new System.Windows.Forms.RadioButton();
            this.rbEchipament = new System.Windows.Forms.RadioButton();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtFunctieTip = new System.Windows.Forms.TextBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creare Resursa noua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip resursa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Functie/Tip";
            // 
            // rbPersoana
            // 
            this.rbPersoana.AutoSize = true;
            this.rbPersoana.Location = new System.Drawing.Point(238, 248);
            this.rbPersoana.Name = "rbPersoana";
            this.rbPersoana.Size = new System.Drawing.Size(135, 29);
            this.rbPersoana.TabIndex = 4;
            this.rbPersoana.TabStop = true;
            this.rbPersoana.Text = "Persoana";
            this.rbPersoana.UseVisualStyleBackColor = true;
            // 
            // rbEchipament
            // 
            this.rbEchipament.AutoSize = true;
            this.rbEchipament.Location = new System.Drawing.Point(392, 248);
            this.rbEchipament.Name = "rbEchipament";
            this.rbEchipament.Size = new System.Drawing.Size(156, 29);
            this.rbEchipament.TabIndex = 5;
            this.rbEchipament.TabStop = true;
            this.rbEchipament.Text = "Echipament";
            this.rbEchipament.UseVisualStyleBackColor = true;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(238, 339);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(351, 31);
            this.txtNume.TabIndex = 6;
            // 
            // txtFunctieTip
            // 
            this.txtFunctieTip.Location = new System.Drawing.Point(238, 430);
            this.txtFunctieTip.Name = "txtFunctieTip";
            this.txtFunctieTip.Size = new System.Drawing.Size(351, 31);
            this.txtFunctieTip.TabIndex = 7;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(238, 478);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(200, 60);
            this.btnSalvare.TabIndex = 8;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(238, 544);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(200, 60);
            this.btnAnulare.TabIndex = 9;
            this.btnAnulare.Text = "Anuleaza";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // FormCreareResursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 929);
            this.Controls.Add(this.rbEchipament);
            this.Controls.Add(this.rbPersoana);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.txtFunctieTip);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreareResursa";
            this.Text = "FormCreareResursa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPersoana;
        private System.Windows.Forms.RadioButton rbEchipament;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtFunctieTip;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAnulare;
    }
}