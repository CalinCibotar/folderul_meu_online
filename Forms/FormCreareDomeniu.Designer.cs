﻿namespace AgendaActivitati.Forms
{
    partial class FormCreareDomeniu
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
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire Domeniu";
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(237, 425);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(200, 60);
            this.btnSalvare.TabIndex = 1;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click_1);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(237, 503);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(200, 60);
            this.btnAnulare.TabIndex = 2;
            this.btnAnulare.Text = "Anuleaza";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click_1);
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(237, 359);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(200, 31);
            this.txtDenumire.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Creare Domeniu nou";
            // 
            // FormCreareDomeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 929);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.label1);
            this.Name = "FormCreareDomeniu";
            this.Text = "FormCreareDomeniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label label2;
    }
}