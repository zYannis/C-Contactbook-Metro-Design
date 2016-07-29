namespace Kontaktbuch
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.ProfileImage = new System.Windows.Forms.PictureBox();
            this.Firstname = new MetroFramework.Controls.MetroLabel();
            this.lastname = new MetroFramework.Controls.MetroLabel();
            this.street = new MetroFramework.Controls.MetroLabel();
            this.housenumber = new MetroFramework.Controls.MetroLabel();
            this.City = new MetroFramework.Controls.MetroLabel();
            this.country = new MetroFramework.Controls.MetroLabel();
            this.phonenumber = new MetroFramework.Controls.MetroLabel();
            this.email = new MetroFramework.Controls.MetroLabel();
            this.skype = new MetroFramework.Controls.MetroLabel();
            this.birthday = new MetroFramework.Controls.MetroLabel();
            this.Nickname = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileImage
            // 
            this.ProfileImage.Image = global::Kontaktbuch.Properties.Resources.profle_icon;
            this.ProfileImage.Location = new System.Drawing.Point(221, 51);
            this.ProfileImage.Name = "ProfileImage";
            this.ProfileImage.Size = new System.Drawing.Size(133, 131);
            this.ProfileImage.TabIndex = 0;
            this.ProfileImage.TabStop = false;
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Location = new System.Drawing.Point(23, 82);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(65, 19);
            this.Firstname.TabIndex = 1;
            this.Firstname.Text = "Vorname:";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(23, 101);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(75, 19);
            this.lastname.TabIndex = 2;
            this.lastname.Text = "Nachname:";
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Location = new System.Drawing.Point(24, 144);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(49, 19);
            this.street.TabIndex = 3;
            this.street.Text = "Straße:";
            // 
            // housenumber
            // 
            this.housenumber.AutoSize = true;
            this.housenumber.Location = new System.Drawing.Point(24, 163);
            this.housenumber.Name = "housenumber";
            this.housenumber.Size = new System.Drawing.Size(91, 19);
            this.housenumber.TabIndex = 4;
            this.housenumber.Text = "Hausnummer:";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(24, 182);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(42, 19);
            this.City.TabIndex = 5;
            this.City.Text = "Stadt:";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(23, 201);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(40, 19);
            this.country.TabIndex = 6;
            this.country.Text = "Land:";
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSize = true;
            this.phonenumber.Location = new System.Drawing.Point(24, 241);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(104, 19);
            this.phonenumber.TabIndex = 7;
            this.phonenumber.Text = "Telefonnummer:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(24, 260);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(44, 19);
            this.email.TabIndex = 8;
            this.email.Text = "Email:";
            // 
            // skype
            // 
            this.skype.AutoSize = true;
            this.skype.Location = new System.Drawing.Point(24, 279);
            this.skype.Name = "skype";
            this.skype.Size = new System.Drawing.Size(46, 19);
            this.skype.TabIndex = 9;
            this.skype.Text = "Skype:";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(24, 317);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(77, 19);
            this.birthday.TabIndex = 10;
            this.birthday.Text = "Geburtstag:";
            this.birthday.Click += new System.EventHandler(this.birthday_Click);
            // 
            // Nickname
            // 
            this.Nickname.AutoSize = true;
            this.Nickname.Location = new System.Drawing.Point(24, 298);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(70, 19);
            this.Nickname.TabIndex = 11;
            this.Nickname.Text = "Nickname:";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(377, 488);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.skype);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.country);
            this.Controls.Add(this.City);
            this.Controls.Add(this.housenumber);
            this.Controls.Add(this.street);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.ProfileImage);
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfileImage;
        private MetroFramework.Controls.MetroLabel Firstname;
        private MetroFramework.Controls.MetroLabel lastname;
        private MetroFramework.Controls.MetroLabel street;
        private MetroFramework.Controls.MetroLabel housenumber;
        private MetroFramework.Controls.MetroLabel City;
        private MetroFramework.Controls.MetroLabel country;
        private MetroFramework.Controls.MetroLabel phonenumber;
        private MetroFramework.Controls.MetroLabel email;
        private MetroFramework.Controls.MetroLabel skype;
        private MetroFramework.Controls.MetroLabel birthday;
        private MetroFramework.Controls.MetroLabel Nickname;
    }
}