
namespace Depressurizer {
    partial class DlgManualDownload {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgManualDownload));
            this.radId = new System.Windows.Forms.RadioButton();
            this.radUrl = new System.Windows.Forms.RadioButton();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radId
            // 
            resources.ApplyResources(this.radId, "radId");
            this.radId.Name = "radId";
            this.radId.UseVisualStyleBackColor = true;
            // 
            // radUrl
            // 
            resources.ApplyResources(this.radUrl, "radUrl");
            this.radUrl.Checked = true;
            this.radUrl.Name = "radUrl";
            this.radUrl.TabStop = true;
            this.radUrl.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            resources.ApplyResources(this.cmdCancel, "cmdCancel");
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            resources.ApplyResources(this.cmdOk, "cmdOk");
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // txtEntry
            // 
            resources.ApplyResources(this.txtEntry, "txtEntry");
            this.txtEntry.Name = "txtEntry";
            // 
            // lblEnter
            // 
            resources.ApplyResources(this.lblEnter, "lblEnter");
            this.lblEnter.Name = "lblEnter";
            // 
            // DlgManualDownload
            // 
            this.AcceptButton = this.cmdOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ControlBox = false;
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.radUrl);
            this.Controls.Add(this.radId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgManualDownload";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radId;
        private System.Windows.Forms.RadioButton radUrl;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Label lblEnter;
    }
}