namespace AccountLookup
{
    partial class AccountLookupForm
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
            this.FieldSearchBox = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelFullname = new System.Windows.Forms.Label();
            this.LabelSUId = new System.Windows.Forms.Label();
            this.LabelAccountExpires = new System.Windows.Forms.Label();
            this.LabelAccountActive = new System.Windows.Forms.Label();
            this.LabelPasswordLastSet = new System.Windows.Forms.Label();
            this.LabelPasswordExpires = new System.Windows.Forms.Label();
            this.LabelPasswordChangeable = new System.Windows.Forms.Label();
            this.LabelPasswordRequired = new System.Windows.Forms.Label();
            this.LabelLastLogon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FieldSearchBox
            // 
            this.FieldSearchBox.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldSearchBox.Location = new System.Drawing.Point(43, 12);
            this.FieldSearchBox.Name = "FieldSearchBox";
            this.FieldSearchBox.Size = new System.Drawing.Size(142, 19);
            this.FieldSearchBox.TabIndex = 0;
            this.FieldSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FieldSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FieldSearchBox_KeyDown);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSearch.Location = new System.Drawing.Point(189, 9);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(63, 25);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FieldSearchBox_KeyDown);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(91, 71);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(64, 15);
            this.LabelUsername.TabIndex = 2;
            this.LabelUsername.Text = "username:";
            // 
            // LabelFullname
            // 
            this.LabelFullname.AutoSize = true;
            this.LabelFullname.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFullname.Location = new System.Drawing.Point(95, 86);
            this.LabelFullname.Name = "LabelFullname";
            this.LabelFullname.Size = new System.Drawing.Size(60, 15);
            this.LabelFullname.TabIndex = 3;
            this.LabelFullname.Text = "full name:";
            // 
            // LabelSUId
            // 
            this.LabelSUId.AutoSize = true;
            this.LabelSUId.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSUId.Location = new System.Drawing.Point(119, 101);
            this.LabelSUId.Name = "LabelSUId";
            this.LabelSUId.Size = new System.Drawing.Size(36, 15);
            this.LabelSUId.TabIndex = 4;
            this.LabelSUId.Text = "su id:";
            // 
            // LabelAccountExpires
            // 
            this.LabelAccountExpires.AutoSize = true;
            this.LabelAccountExpires.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccountExpires.Location = new System.Drawing.Point(59, 146);
            this.LabelAccountExpires.Name = "LabelAccountExpires";
            this.LabelAccountExpires.Size = new System.Drawing.Size(96, 15);
            this.LabelAccountExpires.TabIndex = 6;
            this.LabelAccountExpires.Text = "account expires:";
            // 
            // LabelAccountActive
            // 
            this.LabelAccountActive.AutoSize = true;
            this.LabelAccountActive.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccountActive.Location = new System.Drawing.Point(68, 131);
            this.LabelAccountActive.Name = "LabelAccountActive";
            this.LabelAccountActive.Size = new System.Drawing.Size(87, 15);
            this.LabelAccountActive.TabIndex = 8;
            this.LabelAccountActive.Text = "account active:";
            // 
            // LabelPasswordLastSet
            // 
            this.LabelPasswordLastSet.AutoSize = true;
            this.LabelPasswordLastSet.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswordLastSet.Location = new System.Drawing.Point(52, 174);
            this.LabelPasswordLastSet.Name = "LabelPasswordLastSet";
            this.LabelPasswordLastSet.Size = new System.Drawing.Size(103, 15);
            this.LabelPasswordLastSet.TabIndex = 10;
            this.LabelPasswordLastSet.Text = "password last set:";
            // 
            // LabelPasswordExpires
            // 
            this.LabelPasswordExpires.AutoSize = true;
            this.LabelPasswordExpires.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswordExpires.Location = new System.Drawing.Point(50, 189);
            this.LabelPasswordExpires.Name = "LabelPasswordExpires";
            this.LabelPasswordExpires.Size = new System.Drawing.Size(105, 15);
            this.LabelPasswordExpires.TabIndex = 11;
            this.LabelPasswordExpires.Text = "password expires:";
            // 
            // LabelPasswordChangeable
            // 
            this.LabelPasswordChangeable.AutoSize = true;
            this.LabelPasswordChangeable.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswordChangeable.Location = new System.Drawing.Point(29, 204);
            this.LabelPasswordChangeable.Name = "LabelPasswordChangeable";
            this.LabelPasswordChangeable.Size = new System.Drawing.Size(126, 15);
            this.LabelPasswordChangeable.TabIndex = 12;
            this.LabelPasswordChangeable.Text = "password changeable:";
            // 
            // LabelPasswordRequired
            // 
            this.LabelPasswordRequired.AutoSize = true;
            this.LabelPasswordRequired.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswordRequired.Location = new System.Drawing.Point(44, 219);
            this.LabelPasswordRequired.Name = "LabelPasswordRequired";
            this.LabelPasswordRequired.Size = new System.Drawing.Size(111, 15);
            this.LabelPasswordRequired.TabIndex = 13;
            this.LabelPasswordRequired.Text = "password required:";
            // 
            // LabelLastLogon
            // 
            this.LabelLastLogon.AutoSize = true;
            this.LabelLastLogon.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastLogon.Location = new System.Drawing.Point(92, 249);
            this.LabelLastLogon.Name = "LabelLastLogon";
            this.LabelLastLogon.Size = new System.Drawing.Size(63, 15);
            this.LabelLastLogon.TabIndex = 14;
            this.LabelLastLogon.Text = "last logon:";
            // 
            // AccountLookupForm
            // 
            this.AccessibleName = "Account Lookup";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(462, 444);
            this.Controls.Add(this.LabelLastLogon);
            this.Controls.Add(this.LabelPasswordRequired);
            this.Controls.Add(this.LabelPasswordChangeable);
            this.Controls.Add(this.LabelPasswordExpires);
            this.Controls.Add(this.LabelPasswordLastSet);
            this.Controls.Add(this.LabelAccountActive);
            this.Controls.Add(this.LabelAccountExpires);
            this.Controls.Add(this.LabelSUId);
            this.Controls.Add(this.LabelFullname);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.FieldSearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "AccountLookupForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FieldSearchBox;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelFullname;
        private System.Windows.Forms.Label LabelSUId;
        private System.Windows.Forms.Label LabelAccountExpires;
        private System.Windows.Forms.Label LabelAccountActive;
        private System.Windows.Forms.Label LabelPasswordLastSet;
        private System.Windows.Forms.Label LabelPasswordExpires;
        private System.Windows.Forms.Label LabelPasswordChangeable;
        private System.Windows.Forms.Label LabelPasswordRequired;
        private System.Windows.Forms.Label LabelLastLogon;
    }
}

