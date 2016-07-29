namespace Kontaktbuch
{
    partial class StartSeite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartSeite));
            this.ContactSizeLabel = new MetroFramework.Controls.MetroLabel();
            this.ContactBookButton = new MetroFramework.Controls.MetroButton();
            this.addContactButton = new MetroFramework.Controls.MetroButton();
            this.ad = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // ContactSizeLabel
            // 
            this.ContactSizeLabel.AutoSize = true;
            this.ContactSizeLabel.Location = new System.Drawing.Point(23, 78);
            this.ContactSizeLabel.Name = "ContactSizeLabel";
            this.ContactSizeLabel.Size = new System.Drawing.Size(110, 19);
            this.ContactSizeLabel.Style = MetroFramework.MetroColorStyle.Lime;
            this.ContactSizeLabel.TabIndex = 0;
            this.ContactSizeLabel.Text = "Deine Kontakte: 0";
            // 
            // ContactBookButton
            // 
            this.ContactBookButton.Location = new System.Drawing.Point(411, 318);
            this.ContactBookButton.Name = "ContactBookButton";
            this.ContactBookButton.Size = new System.Drawing.Size(133, 31);
            this.ContactBookButton.TabIndex = 1;
            this.ContactBookButton.Text = "Kontaktbuch";
            this.ContactBookButton.UseSelectable = true;
            this.ContactBookButton.Click += new System.EventHandler(this.ContactBookButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(248, 318);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(133, 31);
            this.addContactButton.TabIndex = 2;
            this.addContactButton.Text = "Kontakt hinzufügen";
            this.addContactButton.UseSelectable = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // ad
            // 
            this.ad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ad.Location = new System.Drawing.Point(23, 318);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(149, 32);
            this.ad.TabIndex = 3;
            this.ad.Text = "by BukkitTNT";
            this.ad.UseSelectable = true;
            this.ad.Click += new System.EventHandler(this.ad_Click);
            // 
            // StartSeite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 372);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.ContactBookButton);
            this.Controls.Add(this.ContactSizeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartSeite";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "PixelContact | Start";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.StartSeite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ContactSizeLabel;
        private MetroFramework.Controls.MetroButton ContactBookButton;
        private MetroFramework.Controls.MetroButton addContactButton;
        private MetroFramework.Controls.MetroLink ad;
    }
}

