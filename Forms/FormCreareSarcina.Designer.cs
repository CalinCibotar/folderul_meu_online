namespace AgendaActivitati.Forms
{
    partial class FormCreareSarcina
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
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.cbPrioritate = new System.Windows.Forms.ComboBox();
            this.ckbCompletat = new System.Windows.Forms.CheckBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creare Sarcina noua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descriere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prioritate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Completat";
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(222, 229);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(236, 72);
            this.txtDescriere.TabIndex = 4;
            // 
            // cbPrioritate
            // 
            this.cbPrioritate.FormattingEnabled = true;
            this.cbPrioritate.Location = new System.Drawing.Point(222, 365);
            this.cbPrioritate.Name = "cbPrioritate";
            this.cbPrioritate.Size = new System.Drawing.Size(236, 33);
            this.cbPrioritate.TabIndex = 5;
            // 
            // ckbCompletat
            // 
            this.ckbCompletat.AutoSize = true;
            this.ckbCompletat.Location = new System.Drawing.Point(223, 474);
            this.ckbCompletat.Name = "ckbCompletat";
            this.ckbCompletat.Size = new System.Drawing.Size(137, 29);
            this.ckbCompletat.TabIndex = 6;
            this.ckbCompletat.Text = "completat";
            this.ckbCompletat.UseVisualStyleBackColor = true;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(222, 533);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(200, 60);
            this.btnSalvare.TabIndex = 7;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(222, 599);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(200, 60);
            this.btnAnulare.TabIndex = 8;
            this.btnAnulare.Text = "Anuleaza";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // FormCreareSarcina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 929);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.ckbCompletat);
            this.Controls.Add(this.cbPrioritate);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreareSarcina";
            this.Text = "FormCreareSarcina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.ComboBox cbPrioritate;
        private System.Windows.Forms.CheckBox ckbCompletat;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAnulare;
    }
}