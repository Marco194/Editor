namespace EditorHtml
{
    partial class Attenzione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attenzione));
            this.label1 = new System.Windows.Forms.Label();
            this.si = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sei sicuro di voler uscire  dal programma?";
            // 
            // si
            // 
            this.si.Location = new System.Drawing.Point(125, 81);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(75, 23);
            this.si.TabIndex = 2;
            this.si.Text = "Si";
            this.si.UseVisualStyleBackColor = true;
            this.si.Click += new System.EventHandler(this.si_Click);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(348, 81);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(75, 23);
            this.no.TabIndex = 3;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // Attenzione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 134);
            this.Controls.Add(this.no);
            this.Controls.Add(this.si);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attenzione";
            this.Text = "Attenzione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button si;
        private System.Windows.Forms.Button no;
    }
}