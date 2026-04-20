namespace FORM1
{
    partial class frmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimeClock = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPricebook = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnStoreStatus = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME  !";
            // 
            // btnTimeClock
            // 
            this.btnTimeClock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTimeClock.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeClock.Image = global::FORM1.Properties.Resources.clock;
            this.btnTimeClock.Location = new System.Drawing.Point(665, 349);
            this.btnTimeClock.Name = "btnTimeClock";
            this.btnTimeClock.Size = new System.Drawing.Size(236, 210);
            this.btnTimeClock.TabIndex = 0;
            this.btnTimeClock.Text = "Time Clock";
            this.btnTimeClock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimeClock.UseVisualStyleBackColor = false;
            this.btnTimeClock.Click += new System.EventHandler(this.btnTimeClock_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLogout.Location = new System.Drawing.Point(148, 581);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 51);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "HI, Rylee Rodil";
            // 
            // btnPricebook
            // 
            this.btnPricebook.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPricebook.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPricebook.Image = global::FORM1.Properties.Resources.book;
            this.btnPricebook.Location = new System.Drawing.Point(665, 121);
            this.btnPricebook.Name = "btnPricebook";
            this.btnPricebook.Size = new System.Drawing.Size(236, 210);
            this.btnPricebook.TabIndex = 0;
            this.btnPricebook.Text = "Pricebook";
            this.btnPricebook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPricebook.UseVisualStyleBackColor = false;
            this.btnPricebook.Click += new System.EventHandler(this.btnPricebook_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVendors.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendors.Image = global::FORM1.Properties.Resources.global;
            this.btnVendors.Location = new System.Drawing.Point(148, 349);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(236, 210);
            this.btnVendors.TabIndex = 0;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendors.UseVisualStyleBackColor = false;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = global::FORM1.Properties.Resources.profile;
            this.btnUsers.Location = new System.Drawing.Point(407, 349);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(236, 210);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnStoreStatus
            // 
            this.btnStoreStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStoreStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreStatus.Image = global::FORM1.Properties.Resources.store;
            this.btnStoreStatus.Location = new System.Drawing.Point(407, 121);
            this.btnStoreStatus.Name = "btnStoreStatus";
            this.btnStoreStatus.Size = new System.Drawing.Size(236, 210);
            this.btnStoreStatus.TabIndex = 0;
            this.btnStoreStatus.Text = "Store Status";
            this.btnStoreStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStoreStatus.UseVisualStyleBackColor = false;
            this.btnStoreStatus.Click += new System.EventHandler(this.btnStoreStatus_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Image = global::FORM1.Properties.Resources.verify;
            this.btnRegister.Location = new System.Drawing.Point(148, 121);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(236, 210);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 670);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimeClock);
            this.Controls.Add(this.btnPricebook);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnStoreStatus);
            this.Controls.Add(this.btnRegister);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStoreStatus;
        private System.Windows.Forms.Button btnPricebook;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnTimeClock;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
    }
}