namespace RPGame
{
    partial class Scene
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHP = new System.Windows.Forms.Label();
            this.lbGold = new System.Windows.Forms.Label();
            this.lbEXP = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EXP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level";
            // 
            // lbHP
            // 
            this.lbHP.AutoSize = true;
            this.lbHP.Location = new System.Drawing.Point(59, 13);
            this.lbHP.Name = "lbHP";
            this.lbHP.Size = new System.Drawing.Size(0, 13);
            this.lbHP.TabIndex = 4;
            // 
            // lbGold
            // 
            this.lbGold.AutoSize = true;
            this.lbGold.Location = new System.Drawing.Point(59, 35);
            this.lbGold.Name = "lbGold";
            this.lbGold.Size = new System.Drawing.Size(0, 13);
            this.lbGold.TabIndex = 5;
            // 
            // lbEXP
            // 
            this.lbEXP.AutoSize = true;
            this.lbEXP.Location = new System.Drawing.Point(59, 58);
            this.lbEXP.Name = "lbEXP";
            this.lbEXP.Size = new System.Drawing.Size(0, 13);
            this.lbEXP.TabIndex = 6;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(59, 80);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(0, 13);
            this.lbLevel.TabIndex = 7;
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 380);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbEXP);
            this.Controls.Add(this.lbGold);
            this.Controls.Add(this.lbHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Scene";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Scene_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHP;
        private System.Windows.Forms.Label lbGold;
        private System.Windows.Forms.Label lbEXP;
        private System.Windows.Forms.Label lbLevel;
    }
}

