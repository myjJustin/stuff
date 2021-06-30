
namespace aufgabe_3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbRot = new System.Windows.Forms.CheckBox();
            this.cbGelb = new System.Windows.Forms.CheckBox();
            this.cbGruen = new System.Windows.Forms.CheckBox();
            this.pRot = new System.Windows.Forms.Panel();
            this.pGelb = new System.Windows.Forms.Panel();
            this.pGruen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cbLauf = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbRot
            // 
            this.cbRot.AutoSize = true;
            this.cbRot.Location = new System.Drawing.Point(79, 39);
            this.cbRot.Name = "cbRot";
            this.cbRot.Size = new System.Drawing.Size(43, 17);
            this.cbRot.TabIndex = 0;
            this.cbRot.Text = "Rot";
            this.cbRot.UseVisualStyleBackColor = true;
            this.cbRot.CheckedChanged += new System.EventHandler(this.cbRot_CheckedChanged);
            // 
            // cbGelb
            // 
            this.cbGelb.AutoSize = true;
            this.cbGelb.Location = new System.Drawing.Point(79, 163);
            this.cbGelb.Name = "cbGelb";
            this.cbGelb.Size = new System.Drawing.Size(48, 17);
            this.cbGelb.TabIndex = 1;
            this.cbGelb.Text = "Gelb";
            this.cbGelb.UseVisualStyleBackColor = true;
            this.cbGelb.CheckedChanged += new System.EventHandler(this.cbGelb_CheckedChanged);
            // 
            // cbGruen
            // 
            this.cbGruen.AutoSize = true;
            this.cbGruen.Location = new System.Drawing.Point(79, 306);
            this.cbGruen.Name = "cbGruen";
            this.cbGruen.Size = new System.Drawing.Size(49, 17);
            this.cbGruen.TabIndex = 2;
            this.cbGruen.Text = "Grün";
            this.cbGruen.UseVisualStyleBackColor = true;
            this.cbGruen.CheckedChanged += new System.EventHandler(this.cbGruen_CheckedChanged);
            // 
            // pRot
            // 
            this.pRot.BackColor = System.Drawing.Color.Black;
            this.pRot.Location = new System.Drawing.Point(233, 39);
            this.pRot.Name = "pRot";
            this.pRot.Size = new System.Drawing.Size(106, 100);
            this.pRot.TabIndex = 3;
            // 
            // pGelb
            // 
            this.pGelb.BackColor = System.Drawing.Color.Black;
            this.pGelb.Location = new System.Drawing.Point(233, 163);
            this.pGelb.Name = "pGelb";
            this.pGelb.Size = new System.Drawing.Size(106, 100);
            this.pGelb.TabIndex = 4;
            // 
            // pGruen
            // 
            this.pGruen.BackColor = System.Drawing.Color.Black;
            this.pGruen.Location = new System.Drawing.Point(233, 306);
            this.pGruen.Name = "pGruen";
            this.pGruen.Size = new System.Drawing.Size(106, 100);
            this.pGruen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cbLauf
            // 
            this.cbLauf.AutoSize = true;
            this.cbLauf.Location = new System.Drawing.Point(79, 388);
            this.cbLauf.Name = "cbLauf";
            this.cbLauf.Size = new System.Drawing.Size(66, 17);
            this.cbLauf.TabIndex = 7;
            this.cbLauf.Text = "Lauflicht";
            this.cbLauf.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbLauf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pGruen);
            this.Controls.Add(this.pGelb);
            this.Controls.Add(this.pRot);
            this.Controls.Add(this.cbGruen);
            this.Controls.Add(this.cbGelb);
            this.Controls.Add(this.cbRot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbRot;
        private System.Windows.Forms.CheckBox cbGelb;
        private System.Windows.Forms.CheckBox cbGruen;
        private System.Windows.Forms.Panel pRot;
        private System.Windows.Forms.Panel pGelb;
        private System.Windows.Forms.Panel pGruen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox cbLauf;
    }
}

