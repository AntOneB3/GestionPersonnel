
namespace GestionPersonnel
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.text1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(320, 240);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(75, 23);
            this.text1.TabIndex = 0;
            this.text1.Text = "text1";
            this.text1.UseVisualStyleBackColor = true;
            this.text1.Click += new System.EventHandler(this.text1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(424, 240);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(75, 23);
            this.text2.TabIndex = 2;
            this.text2.Text = "text2";
            this.text2.UseVisualStyleBackColor = true;
            this.text2.Click += new System.EventHandler(this.text2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 549);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button text2;
    }
}

