namespace WinApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.listBoxLeft = new System.Windows.Forms.ListBox();
            this.listBoxRight = new System.Windows.Forms.ListBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.listViewCompare = new System.Windows.Forms.ListView();
            this.labelStats = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.buttonApropos = new System.Windows.Forms.Button();
            this.labelHelpCompare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Location = new System.Drawing.Point(91, 13);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(120, 20);
            this.textBoxLeft.TabIndex = 0;
            this.textBoxLeft.Text = "RE";
            // 
            // textBoxRight
            // 
            this.textBoxRight.Location = new System.Drawing.Point(735, 12);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(120, 20);
            this.textBoxRight.TabIndex = 1;
            this.textBoxRight.Text = "RE";
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(217, 13);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 20);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "OK";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(861, 11);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 20);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "OK";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // listBoxLeft
            // 
            this.listBoxLeft.FormattingEnabled = true;
            this.listBoxLeft.Location = new System.Drawing.Point(56, 67);
            this.listBoxLeft.Name = "listBoxLeft";
            this.listBoxLeft.Size = new System.Drawing.Size(250, 290);
            this.listBoxLeft.TabIndex = 4;
            // 
            // listBoxRight
            // 
            this.listBoxRight.FormattingEnabled = true;
            this.listBoxRight.Location = new System.Drawing.Point(698, 67);
            this.listBoxRight.Name = "listBoxRight";
            this.listBoxRight.Size = new System.Drawing.Size(250, 290);
            this.listBoxRight.TabIndex = 5;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(456, 13);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(103, 44);
            this.buttonCompare.TabIndex = 6;
            this.buttonCompare.Text = "Comparer";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // listViewCompare
            // 
            this.listViewCompare.Location = new System.Drawing.Point(382, 67);
            this.listViewCompare.Name = "listViewCompare";
            this.listViewCompare.Size = new System.Drawing.Size(250, 290);
            this.listViewCompare.TabIndex = 8;
            this.listViewCompare.UseCompatibleStateImageBehavior = false;
            this.listViewCompare.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewCompare_MouseDoubleClick);
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Location = new System.Drawing.Point(12, 388);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(0, 13);
            this.labelStats.TabIndex = 9;
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Location = new System.Drawing.Point(132, 51);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(99, 13);
            this.labelLeft.TabIndex = 10;
            this.labelLeft.Text = "Entrez un utilisateur";
            this.labelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Location = new System.Drawing.Point(774, 51);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(99, 13);
            this.labelRight.TabIndex = 11;
            this.labelRight.Text = "Entrez un utilisateur";
            this.labelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonApropos
            // 
            this.buttonApropos.Location = new System.Drawing.Point(918, 378);
            this.buttonApropos.Name = "buttonApropos";
            this.buttonApropos.Size = new System.Drawing.Size(75, 23);
            this.buttonApropos.TabIndex = 12;
            this.buttonApropos.Text = "A propos";
            this.buttonApropos.UseVisualStyleBackColor = true;
            this.buttonApropos.Click += new System.EventHandler(this.buttonApropos_Click);
            // 
            // labelHelpCompare
            // 
            this.labelHelpCompare.AutoSize = true;
            this.labelHelpCompare.Location = new System.Drawing.Point(362, 360);
            this.labelHelpCompare.Name = "labelHelpCompare";
            this.labelHelpCompare.Size = new System.Drawing.Size(300, 13);
            this.labelHelpCompare.TabIndex = 13;
            this.labelHelpCompare.Text = "Double-cliquez sur un groupe pour l\'ajouter du côté manquant.";
            this.labelHelpCompare.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelHelpCompare.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 413);
            this.Controls.Add(this.labelHelpCompare);
            this.Controls.Add(this.buttonApropos);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.listViewCompare);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.listBoxRight);
            this.Controls.Add(this.listBoxLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.textBoxRight);
            this.Controls.Add(this.textBoxLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "CompAdG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.ListBox listBoxLeft;
        private System.Windows.Forms.ListBox listBoxRight;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.ListView listViewCompare;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Button buttonApropos;
        private System.Windows.Forms.Label labelHelpCompare;
    }
}

