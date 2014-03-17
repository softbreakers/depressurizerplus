﻿
namespace Depressurizer {
    partial class DlgProfile {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgProfile));
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.txtUserUrl = new System.Windows.Forms.TextBox();
            this.radSelUserByURL = new System.Windows.Forms.RadioButton();
            this.radSelUserByID = new System.Windows.Forms.RadioButton();
            this.radSelUserFromList = new System.Windows.Forms.RadioButton();
            this.cmdUserUpdateCancel = new System.Windows.Forms.Button();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.cmdUserUpdate = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.grpProfInfo = new System.Windows.Forms.GroupBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.chkSetStartup = new System.Windows.Forms.CheckBox();
            this.chkActImport = new System.Windows.Forms.CheckBox();
            this.chkActDownload = new System.Windows.Forms.CheckBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.grpLoadOpt = new System.Windows.Forms.GroupBox();
            this.chkAutoImport = new System.Windows.Forms.CheckBox();
            this.chkAutoDownload = new System.Windows.Forms.CheckBox();
            this.grpSaveOpt = new System.Windows.Forms.GroupBox();
            this.chkExportDiscard = new System.Windows.Forms.CheckBox();
            this.chkAutoExport = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabOpts = new System.Windows.Forms.TabPage();
            this.grpOtherOpt = new System.Windows.Forms.GroupBox();
            this.chkOverwriteNames = new System.Windows.Forms.CheckBox();
            this.tabIgnore = new System.Windows.Forms.TabPage();
            this.grpIgnored = new System.Windows.Forms.GroupBox();
            this.cmdIgnore = new System.Windows.Forms.Button();
            this.txtIgnore = new System.Windows.Forms.TextBox();
            this.cmdUnignore = new System.Windows.Forms.Button();
            this.lstIgnored = new System.Windows.Forms.ListView();
            this.grpIgnoreSettings = new System.Windows.Forms.GroupBox();
            this.chkIgnoreExternal = new System.Windows.Forms.CheckBox();
            this.chkIgnoreDlc = new System.Windows.Forms.CheckBox();
            this.chkAutoIgnore = new System.Windows.Forms.CheckBox();
            this.grpUserInfo.SuspendLayout();
            this.grpProfInfo.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpLoadOpt.SuspendLayout();
            this.grpSaveOpt.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabOpts.SuspendLayout();
            this.grpOtherOpt.SuspendLayout();
            this.tabIgnore.SuspendLayout();
            this.grpIgnored.SuspendLayout();
            this.grpIgnoreSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            resources.ApplyResources(this.txtFilePath, "txtFilePath");
            this.txtFilePath.Name = "txtFilePath";
            // 
            // cmdBrowse
            // 
            resources.ApplyResources(this.cmdBrowse, "cmdBrowse");
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // lblPath
            // 
            resources.ApplyResources(this.lblPath, "lblPath");
            this.lblPath.Name = "lblPath";
            // 
            // grpUserInfo
            // 
            resources.ApplyResources(this.grpUserInfo, "grpUserInfo");
            this.grpUserInfo.Controls.Add(this.txtUserUrl);
            this.grpUserInfo.Controls.Add(this.radSelUserByURL);
            this.grpUserInfo.Controls.Add(this.radSelUserByID);
            this.grpUserInfo.Controls.Add(this.radSelUserFromList);
            this.grpUserInfo.Controls.Add(this.cmdUserUpdateCancel);
            this.grpUserInfo.Controls.Add(this.lblUserStatus);
            this.grpUserInfo.Controls.Add(this.cmdUserUpdate);
            this.grpUserInfo.Controls.Add(this.txtUserID);
            this.grpUserInfo.Controls.Add(this.lstUsers);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.TabStop = false;
            // 
            // txtUserUrl
            // 
            resources.ApplyResources(this.txtUserUrl, "txtUserUrl");
            this.txtUserUrl.Name = "txtUserUrl";
            // 
            // radSelUserByURL
            // 
            resources.ApplyResources(this.radSelUserByURL, "radSelUserByURL");
            this.radSelUserByURL.Name = "radSelUserByURL";
            this.radSelUserByURL.TabStop = true;
            this.radSelUserByURL.UseVisualStyleBackColor = true;
            this.radSelUserByURL.CheckedChanged += new System.EventHandler(this.radSelUser_CheckedChanged);
            // 
            // radSelUserByID
            // 
            resources.ApplyResources(this.radSelUserByID, "radSelUserByID");
            this.radSelUserByID.Name = "radSelUserByID";
            this.radSelUserByID.TabStop = true;
            this.radSelUserByID.UseVisualStyleBackColor = true;
            this.radSelUserByID.CheckedChanged += new System.EventHandler(this.radSelUser_CheckedChanged);
            // 
            // radSelUserFromList
            // 
            resources.ApplyResources(this.radSelUserFromList, "radSelUserFromList");
            this.radSelUserFromList.Name = "radSelUserFromList";
            this.radSelUserFromList.TabStop = true;
            this.radSelUserFromList.UseVisualStyleBackColor = true;
            this.radSelUserFromList.CheckedChanged += new System.EventHandler(this.radSelUser_CheckedChanged);
            // 
            // cmdUserUpdateCancel
            // 
            resources.ApplyResources(this.cmdUserUpdateCancel, "cmdUserUpdateCancel");
            this.cmdUserUpdateCancel.Name = "cmdUserUpdateCancel";
            this.cmdUserUpdateCancel.UseVisualStyleBackColor = true;
            this.cmdUserUpdateCancel.Click += new System.EventHandler(this.cmdUserUpdateCancel_Click);
            // 
            // lblUserStatus
            // 
            resources.ApplyResources(this.lblUserStatus, "lblUserStatus");
            this.lblUserStatus.Name = "lblUserStatus";
            // 
            // cmdUserUpdate
            // 
            resources.ApplyResources(this.cmdUserUpdate, "cmdUserUpdate");
            this.cmdUserUpdate.Name = "cmdUserUpdate";
            this.cmdUserUpdate.UseVisualStyleBackColor = true;
            this.cmdUserUpdate.Click += new System.EventHandler(this.cmdUserUpdate_Click);
            // 
            // txtUserID
            // 
            resources.ApplyResources(this.txtUserID, "txtUserID");
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // lstUsers
            // 
            resources.ApplyResources(this.lstUsers, "lstUsers");
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // grpProfInfo
            // 
            resources.ApplyResources(this.grpProfInfo, "grpProfInfo");
            this.grpProfInfo.Controls.Add(this.txtFilePath);
            this.grpProfInfo.Controls.Add(this.cmdBrowse);
            this.grpProfInfo.Controls.Add(this.lblPath);
            this.grpProfInfo.Name = "grpProfInfo";
            this.grpProfInfo.TabStop = false;
            // 
            // grpActions
            // 
            resources.ApplyResources(this.grpActions, "grpActions");
            this.grpActions.Controls.Add(this.chkSetStartup);
            this.grpActions.Controls.Add(this.chkActImport);
            this.grpActions.Controls.Add(this.chkActDownload);
            this.grpActions.Name = "grpActions";
            this.grpActions.TabStop = false;
            // 
            // chkSetStartup
            // 
            resources.ApplyResources(this.chkSetStartup, "chkSetStartup");
            this.chkSetStartup.Checked = true;
            this.chkSetStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSetStartup.Name = "chkSetStartup";
            this.chkSetStartup.UseVisualStyleBackColor = true;
            // 
            // chkActImport
            // 
            resources.ApplyResources(this.chkActImport, "chkActImport");
            this.chkActImport.Checked = true;
            this.chkActImport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActImport.Name = "chkActImport";
            this.chkActImport.UseVisualStyleBackColor = true;
            // 
            // chkActDownload
            // 
            resources.ApplyResources(this.chkActDownload, "chkActDownload");
            this.chkActDownload.Checked = true;
            this.chkActDownload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActDownload.Name = "chkActDownload";
            this.chkActDownload.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            resources.ApplyResources(this.cmdOk, "cmdOk");
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            resources.ApplyResources(this.cmdCancel, "cmdCancel");
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // grpLoadOpt
            // 
            resources.ApplyResources(this.grpLoadOpt, "grpLoadOpt");
            this.grpLoadOpt.Controls.Add(this.chkAutoImport);
            this.grpLoadOpt.Controls.Add(this.chkAutoDownload);
            this.grpLoadOpt.Name = "grpLoadOpt";
            this.grpLoadOpt.TabStop = false;
            // 
            // chkAutoImport
            // 
            resources.ApplyResources(this.chkAutoImport, "chkAutoImport");
            this.chkAutoImport.Name = "chkAutoImport";
            this.chkAutoImport.UseVisualStyleBackColor = true;
            // 
            // chkAutoDownload
            // 
            resources.ApplyResources(this.chkAutoDownload, "chkAutoDownload");
            this.chkAutoDownload.Checked = true;
            this.chkAutoDownload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoDownload.Name = "chkAutoDownload";
            this.chkAutoDownload.UseVisualStyleBackColor = true;
            // 
            // grpSaveOpt
            // 
            resources.ApplyResources(this.grpSaveOpt, "grpSaveOpt");
            this.grpSaveOpt.Controls.Add(this.chkExportDiscard);
            this.grpSaveOpt.Controls.Add(this.chkAutoExport);
            this.grpSaveOpt.Name = "grpSaveOpt";
            this.grpSaveOpt.TabStop = false;
            // 
            // chkExportDiscard
            // 
            resources.ApplyResources(this.chkExportDiscard, "chkExportDiscard");
            this.chkExportDiscard.Checked = true;
            this.chkExportDiscard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportDiscard.Name = "chkExportDiscard";
            this.chkExportDiscard.UseVisualStyleBackColor = true;
            // 
            // chkAutoExport
            // 
            resources.ApplyResources(this.chkAutoExport, "chkAutoExport");
            this.chkAutoExport.Checked = true;
            this.chkAutoExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoExport.Name = "chkAutoExport";
            this.chkAutoExport.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabOpts);
            this.tabControl.Controls.Add(this.tabIgnore);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabMain
            // 
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Controls.Add(this.grpProfInfo);
            this.tabMain.Controls.Add(this.grpUserInfo);
            this.tabMain.Controls.Add(this.grpActions);
            this.tabMain.Name = "tabMain";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabOpts
            // 
            resources.ApplyResources(this.tabOpts, "tabOpts");
            this.tabOpts.Controls.Add(this.grpOtherOpt);
            this.tabOpts.Controls.Add(this.grpSaveOpt);
            this.tabOpts.Controls.Add(this.grpLoadOpt);
            this.tabOpts.Name = "tabOpts";
            this.tabOpts.UseVisualStyleBackColor = true;
            // 
            // grpOtherOpt
            // 
            resources.ApplyResources(this.grpOtherOpt, "grpOtherOpt");
            this.grpOtherOpt.Controls.Add(this.chkOverwriteNames);
            this.grpOtherOpt.Name = "grpOtherOpt";
            this.grpOtherOpt.TabStop = false;
            // 
            // chkOverwriteNames
            // 
            resources.ApplyResources(this.chkOverwriteNames, "chkOverwriteNames");
            this.chkOverwriteNames.Name = "chkOverwriteNames";
            this.chkOverwriteNames.UseVisualStyleBackColor = true;
            // 
            // tabIgnore
            // 
            resources.ApplyResources(this.tabIgnore, "tabIgnore");
            this.tabIgnore.Controls.Add(this.grpIgnored);
            this.tabIgnore.Controls.Add(this.grpIgnoreSettings);
            this.tabIgnore.Name = "tabIgnore";
            this.tabIgnore.UseVisualStyleBackColor = true;
            // 
            // grpIgnored
            // 
            resources.ApplyResources(this.grpIgnored, "grpIgnored");
            this.grpIgnored.Controls.Add(this.cmdIgnore);
            this.grpIgnored.Controls.Add(this.txtIgnore);
            this.grpIgnored.Controls.Add(this.cmdUnignore);
            this.grpIgnored.Controls.Add(this.lstIgnored);
            this.grpIgnored.Name = "grpIgnored";
            this.grpIgnored.TabStop = false;
            // 
            // cmdIgnore
            // 
            resources.ApplyResources(this.cmdIgnore, "cmdIgnore");
            this.cmdIgnore.Name = "cmdIgnore";
            this.cmdIgnore.UseVisualStyleBackColor = true;
            this.cmdIgnore.Click += new System.EventHandler(this.cmdIgnore_Click);
            // 
            // txtIgnore
            // 
            resources.ApplyResources(this.txtIgnore, "txtIgnore");
            this.txtIgnore.Name = "txtIgnore";
            // 
            // cmdUnignore
            // 
            resources.ApplyResources(this.cmdUnignore, "cmdUnignore");
            this.cmdUnignore.Name = "cmdUnignore";
            this.cmdUnignore.UseVisualStyleBackColor = true;
            this.cmdUnignore.Click += new System.EventHandler(this.cmdUnignore_Click);
            // 
            // lstIgnored
            // 
            resources.ApplyResources(this.lstIgnored, "lstIgnored");
            this.lstIgnored.FullRowSelect = true;
            this.lstIgnored.Name = "lstIgnored";
            this.lstIgnored.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstIgnored.UseCompatibleStateImageBehavior = false;
            this.lstIgnored.View = System.Windows.Forms.View.List;
            // 
            // grpIgnoreSettings
            // 
            resources.ApplyResources(this.grpIgnoreSettings, "grpIgnoreSettings");
            this.grpIgnoreSettings.Controls.Add(this.chkIgnoreExternal);
            this.grpIgnoreSettings.Controls.Add(this.chkIgnoreDlc);
            this.grpIgnoreSettings.Controls.Add(this.chkAutoIgnore);
            this.grpIgnoreSettings.Name = "grpIgnoreSettings";
            this.grpIgnoreSettings.TabStop = false;
            // 
            // chkIgnoreExternal
            // 
            resources.ApplyResources(this.chkIgnoreExternal, "chkIgnoreExternal");
            this.chkIgnoreExternal.Checked = true;
            this.chkIgnoreExternal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreExternal.Name = "chkIgnoreExternal";
            this.chkIgnoreExternal.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreDlc
            // 
            resources.ApplyResources(this.chkIgnoreDlc, "chkIgnoreDlc");
            this.chkIgnoreDlc.Checked = true;
            this.chkIgnoreDlc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreDlc.Name = "chkIgnoreDlc";
            this.chkIgnoreDlc.UseVisualStyleBackColor = true;
            // 
            // chkAutoIgnore
            // 
            resources.ApplyResources(this.chkAutoIgnore, "chkAutoIgnore");
            this.chkAutoIgnore.Checked = true;
            this.chkAutoIgnore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoIgnore.Name = "chkAutoIgnore";
            this.chkAutoIgnore.UseVisualStyleBackColor = true;
            // 
            // DlgProfile
            // 
            this.AcceptButton = this.cmdOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DlgProfile";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileDlg_FormClosing);
            this.Load += new System.EventHandler(this.ProfileDlg_Load);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.grpProfInfo.ResumeLayout(false);
            this.grpProfInfo.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.grpLoadOpt.ResumeLayout(false);
            this.grpLoadOpt.PerformLayout();
            this.grpSaveOpt.ResumeLayout(false);
            this.grpSaveOpt.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabOpts.ResumeLayout(false);
            this.grpOtherOpt.ResumeLayout(false);
            this.grpOtherOpt.PerformLayout();
            this.tabIgnore.ResumeLayout(false);
            this.grpIgnored.ResumeLayout(false);
            this.grpIgnored.PerformLayout();
            this.grpIgnoreSettings.ResumeLayout(false);
            this.grpIgnoreSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.GroupBox grpProfInfo;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.CheckBox chkActImport;
        private System.Windows.Forms.CheckBox chkActDownload;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.GroupBox grpLoadOpt;
        private System.Windows.Forms.CheckBox chkAutoImport;
        private System.Windows.Forms.CheckBox chkAutoDownload;
        private System.Windows.Forms.GroupBox grpSaveOpt;
        private System.Windows.Forms.CheckBox chkExportDiscard;
        private System.Windows.Forms.CheckBox chkAutoExport;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabOpts;
        private System.Windows.Forms.CheckBox chkSetStartup;
        private System.Windows.Forms.TabPage tabIgnore;
        private System.Windows.Forms.GroupBox grpIgnored;
        private System.Windows.Forms.Button cmdIgnore;
        private System.Windows.Forms.TextBox txtIgnore;
        private System.Windows.Forms.Button cmdUnignore;
        private System.Windows.Forms.ListView lstIgnored;
        private System.Windows.Forms.GroupBox grpIgnoreSettings;
        private System.Windows.Forms.CheckBox chkAutoIgnore;
        private System.Windows.Forms.GroupBox grpOtherOpt;
        private System.Windows.Forms.CheckBox chkOverwriteNames;
        private System.Windows.Forms.CheckBox chkIgnoreDlc;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Button cmdUserUpdate;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button cmdUserUpdateCancel;
        private System.Windows.Forms.TextBox txtUserUrl;
        private System.Windows.Forms.RadioButton radSelUserByURL;
        private System.Windows.Forms.RadioButton radSelUserByID;
        private System.Windows.Forms.RadioButton radSelUserFromList;
        private System.Windows.Forms.CheckBox chkIgnoreExternal;
    }
}