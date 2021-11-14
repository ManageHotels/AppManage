
namespace ManageRoom
{
    partial class FormDatabaseConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabaseConnect));
            this.gcInfoData = new DevExpress.XtraEditors.GroupControl();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnCheckData = new System.Windows.Forms.Button();
            this.cbbDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbservername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfoData)).BeginInit();
            this.gcInfoData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcInfoData
            // 
            this.gcInfoData.ContentImage = ((System.Drawing.Image)(resources.GetObject("gcInfoData.ContentImage")));
            this.gcInfoData.Controls.Add(this.txtPassword);
            this.gcInfoData.Controls.Add(this.txtUsername);
            this.gcInfoData.Controls.Add(this.txtServer);
            this.gcInfoData.Controls.Add(this.btnSaveData);
            this.gcInfoData.Controls.Add(this.btnCheckData);
            this.gcInfoData.Controls.Add(this.cbbDatabase);
            this.gcInfoData.Controls.Add(this.label1);
            this.gcInfoData.Controls.Add(this.lbPass);
            this.gcInfoData.Controls.Add(this.lbUser);
            this.gcInfoData.Controls.Add(this.lbservername);
            this.gcInfoData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInfoData.Location = new System.Drawing.Point(0, 0);
            this.gcInfoData.Name = "gcInfoData";
            this.gcInfoData.Size = new System.Drawing.Size(527, 330);
            this.gcInfoData.TabIndex = 1;
            this.gcInfoData.Text = "Connection Information";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(146, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(313, 27);
            this.txtPassword.TabIndex = 16;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(146, 113);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(313, 27);
            this.txtUsername.TabIndex = 15;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(146, 68);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(313, 27);
            this.txtServer.TabIndex = 14;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(328, 246);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(131, 45);
            this.btnSaveData.TabIndex = 13;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnCheckData
            // 
            this.btnCheckData.Location = new System.Drawing.Point(146, 246);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(131, 45);
            this.btnCheckData.TabIndex = 12;
            this.btnCheckData.Text = "Check";
            this.btnCheckData.UseVisualStyleBackColor = true;
            this.btnCheckData.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // cbbDatabase
            // 
            this.cbbDatabase.FormattingEnabled = true;
            this.cbbDatabase.Location = new System.Drawing.Point(146, 199);
            this.cbbDatabase.Name = "cbbDatabase";
            this.cbbDatabase.Size = new System.Drawing.Size(313, 27);
            this.cbbDatabase.TabIndex = 11;
            this.cbbDatabase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbDatabase_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Database:  ";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Location = new System.Drawing.Point(31, 154);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(82, 19);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Password:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Location = new System.Drawing.Point(31, 113);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(96, 19);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "User name: ";
            // 
            // lbservername
            // 
            this.lbservername.AutoSize = true;
            this.lbservername.BackColor = System.Drawing.Color.Transparent;
            this.lbservername.Location = new System.Drawing.Point(31, 71);
            this.lbservername.Name = "lbservername";
            this.lbservername.Size = new System.Drawing.Size(109, 19);
            this.lbservername.TabIndex = 0;
            this.lbservername.Text = "Server name: ";
            // 
            // FormDatabaseConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 330);
            this.Controls.Add(this.gcInfoData);
            this.Name = "FormDatabaseConnect";
            this.Text = "FormDatabaseConnect";
            ((System.ComponentModel.ISupportInitialize)(this.gcInfoData)).EndInit();
            this.gcInfoData.ResumeLayout(false);
            this.gcInfoData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcInfoData;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnCheckData;
        private System.Windows.Forms.ComboBox cbbDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbservername;
    }
}