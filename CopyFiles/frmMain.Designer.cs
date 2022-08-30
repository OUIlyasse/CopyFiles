namespace CopyFiles
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkBrowseFile = new System.Windows.Forms.LinkLabel();
            this.linkBrowseFolder = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emplacement de fichier";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(29, 46);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(441, 28);
            this.txtFile.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(169, 187);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(244, 54);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "&Copier";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(29, 136);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(441, 28);
            this.txtFolder.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emplacement de dossier";
            // 
            // linkBrowseFile
            // 
            this.linkBrowseFile.AutoSize = true;
            this.linkBrowseFile.Location = new System.Drawing.Point(485, 51);
            this.linkBrowseFile.Name = "linkBrowseFile";
            this.linkBrowseFile.Size = new System.Drawing.Size(71, 19);
            this.linkBrowseFile.TabIndex = 6;
            this.linkBrowseFile.TabStop = true;
            this.linkBrowseFile.Text = "Choisir";
            // 
            // linkBrowseFolder
            // 
            this.linkBrowseFolder.AutoSize = true;
            this.linkBrowseFolder.Location = new System.Drawing.Point(485, 141);
            this.linkBrowseFolder.Name = "linkBrowseFolder";
            this.linkBrowseFolder.Size = new System.Drawing.Size(71, 19);
            this.linkBrowseFolder.TabIndex = 7;
            this.linkBrowseFolder.TabStop = true;
            this.linkBrowseFolder.Text = "Choisir";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.linkBrowseFolder);
            this.Controls.Add(this.linkBrowseFile);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copier les fichiers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkBrowseFile;
        private System.Windows.Forms.LinkLabel linkBrowseFolder;
    }
}

