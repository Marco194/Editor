namespace EditorHtml
{
    partial class PaginaIniziale
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
            this.gy = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gy.SuspendLayout();
            this.SuspendLayout();
            // 
            // gy
            // 
            this.gy.BackColor = System.Drawing.Color.Transparent;
            this.gy.Controls.Add(this.checkBox1);
            this.gy.Controls.Add(this.checkBox2);
            this.gy.Location = new System.Drawing.Point(535, 181);
            this.gy.Name = "gy";
            this.gy.Size = new System.Drawing.Size(93, 94);
            this.gy.TabIndex = 9;
            this.gy.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Editor";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox1_KeyDown);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(6, 62);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Esci";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Se sei pronto per prorammare la tua pagina web flegga EDITOR qui sotto e premi in" +
    "vio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Benvenuto nell\'editor html/css dove potrai consultare in tempo reale cosa succede" +
    "rà nella tua pagina web";
            // 
            // PaginaIniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EditorHtml.Properties.Resources.htmlcss;
            this.ClientSize = new System.Drawing.Size(678, 302);
            this.Controls.Add(this.gy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PaginaIniziale";
            this.Text = "PaginaIniziale";
            this.Load += new System.EventHandler(this.PaginaIniziale_Load);
            this.gy.ResumeLayout(false);
            this.gy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gy;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}