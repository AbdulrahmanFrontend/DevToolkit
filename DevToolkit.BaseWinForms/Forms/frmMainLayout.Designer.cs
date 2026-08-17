namespace DevToolkit.BaseWinForms.Forms
{
    partial class frmMainLayout
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
            this.sidebar = new DevToolkit.BaseWinForms.Controls.UserControls.ucSidebar();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.headerbar = new DevToolkit.BaseWinForms.Controls.UserControls.ucHeaderbar();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.ButtonIconAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebar.ButtonTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.sidebar.ButtonTextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebar.Location = new System.Drawing.Point(1120, 0);
            this.sidebar.Logo = null;
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sidebar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sidebar.SelectedButtonColor = System.Drawing.Color.Empty;
            this.sidebar.Size = new System.Drawing.Size(223, 493);
            this.sidebar.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlContainer);
            this.pnlMain.Controls.Add(this.headerbar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1120, 493);
            this.pnlMain.TabIndex = 1;
            // 
            // headerbar
            // 
            this.headerbar.ButtonColor = System.Drawing.SystemColors.Control;
            this.headerbar.ButtonImage = null;
            this.headerbar.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerbar.ButtonText = "Action";
            this.headerbar.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerbar.ButtonWidth = 143F;
            this.headerbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerbar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerbar.Location = new System.Drawing.Point(0, 0);
            this.headerbar.Margin = new System.Windows.Forms.Padding(0);
            this.headerbar.Name = "headerbar";
            this.headerbar.Padding = new System.Windows.Forms.Padding(5);
            this.headerbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.headerbar.ShowDate = true;
            this.headerbar.ShowTime = true;
            this.headerbar.ShowUserName = true;
            this.headerbar.Size = new System.Drawing.Size(1120, 50);
            this.headerbar.SystemName = "اسم الشركة/المحل";
            this.headerbar.TabIndex = 0;
            this.headerbar.UserName = "اسم المستخدم";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 50);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlContainer.Size = new System.Drawing.Size(1120, 443);
            this.pnlContainer.TabIndex = 2;
            // 
            // frmMainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1343, 493);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.sidebar);
            this.DoubleBuffered = true;
            this.Name = "frmMainLayout";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainLayout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserControls.ucSidebar sidebar;
        private System.Windows.Forms.Panel pnlMain;
        private Controls.UserControls.ucHeaderbar headerbar;
        private System.Windows.Forms.Panel pnlContainer;
    }
}