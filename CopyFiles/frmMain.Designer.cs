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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.linkBrowseFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(169, 117);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(244, 54);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "&Copier";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFolder.Location = new System.Drawing.Point(29, 66);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(441, 28);
            this.txtFolder.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choisir un emplacement";
            // 
            // ofd
            // 
            this.ofd.Filter = "Tous Fichiers|*.*";
            this.ofd.Title = "Ouvrir des fichiers";
            // 
            // linkBrowseFolder
            // 
            this.linkBrowseFolder.AutoSize = true;
            this.linkBrowseFolder.FlatAppearance.BorderSize = 0;
            this.linkBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkBrowseFolder.Image = global::CopyFiles.Properties.Resources.icons8_folder_36px;
            this.linkBrowseFolder.Location = new System.Drawing.Point(487, 58);
            this.linkBrowseFolder.Name = "linkBrowseFolder";
            this.linkBrowseFolder.Size = new System.Drawing.Size(48, 44);
            this.linkBrowseFolder.TabIndex = 8;
            this.linkBrowseFolder.UseVisualStyleBackColor = true;
            this.linkBrowseFolder.Click += new System.EventHandler(this.linkBrowseFolder_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 201);
            this.Controls.Add(this.linkBrowseFolder);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copier les fichiers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button linkBrowseFolder;
    }
}

