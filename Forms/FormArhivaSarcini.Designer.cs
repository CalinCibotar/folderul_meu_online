namespace AgendaActivitati.Forms
{
    partial class FormArhivaSarcini
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
            this.lvSarciniCurente = new System.Windows.Forms.ListView();
            this.lvSarciniArhivate = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sarcini curente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sarcini Arhivate";
            // 
            // lvSarciniCurente
            // 
            this.lvSarciniCurente.HideSelection = false;
            this.lvSarciniCurente.Location = new System.Drawing.Point(47, 85);
            this.lvSarciniCurente.Name = "lvSarciniCurente";
            this.lvSarciniCurente.Size = new System.Drawing.Size(650, 350);
            this.lvSarciniCurente.TabIndex = 2;
            this.lvSarciniCurente.UseCompatibleStateImageBehavior = false;
            // 
            // lvSarciniArhivate
            // 
            this.lvSarciniArhivate.HideSelection = false;
            this.lvSarciniArhivate.Location = new System.Drawing.Point(711, 85);
            this.lvSarciniArhivate.Name = "lvSarciniArhivate";
            this.lvSarciniArhivate.Size = new System.Drawing.Size(650, 350);
            this.lvSarciniArhivate.TabIndex = 3;
            this.lvSarciniArhivate.UseCompatibleStateImageBehavior = false;
            // 
            // FormArhivaSarcini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 981);
            this.Controls.Add(this.lvSarciniArhivate);
            this.Controls.Add(this.lvSarciniCurente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormArhivaSarcini";
            this.Text = "FormArhivaSarcini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvSarciniCurente;
        private System.Windows.Forms.ListView lvSarciniArhivate;
    }
}