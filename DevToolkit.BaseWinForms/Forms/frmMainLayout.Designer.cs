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
            this.Sidebar = new DevToolkit.BaseWinForms.Controls.UserControls.ucSidebar();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.Headerbar = new DevToolkit.BaseWinForms.Controls.UserControls.ucHeaderbar();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.ButtonHeight = 50;
            this.Sidebar.ButtonIconAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sidebar.ButtonMargin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Sidebar.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.Sidebar.ButtonTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sidebar.ButtonTextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Sidebar.Location = new System.Drawing.Point(1120, 0);
            this.Sidebar.Logo = null;
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Sidebar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sidebar.SelectedButtonColor = System.Drawing.Color.Empty;
            this.Sidebar.Size = new System.Drawing.Size(223, 493);
            this.Sidebar.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlContainer);
            this.pnlMain.Controls.Add(this.Headerbar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1120, 493);
            this.pnlMain.TabIndex = 1;
            // 
            // Headerbar
            // 
            this.Headerbar.ButtonColor = System.Drawing.SystemColors.Control;
            this.Headerbar.ButtonImage = null;
            this.Headerbar.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Headerbar.ButtonText = "Action";
            this.Headerbar.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Headerbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerbar.Location = new System.Drawing.Point(0, 0);
            this.Headerbar.Name = "Headerbar";
            this.Headerbar.Padding = new System.Windows.Forms.Padding(5);
            this.Headerbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Headerbar.ShowDate = true;
            this.Headerbar.ShowTime = true;
            this.Headerbar.ShowUserName = true;
            this.Headerbar.Size = new System.Drawing.Size(1120, 43);
            this.Headerbar.SystemName = "اسم الشركة/المحل";
            this.Headerbar.TabIndex = 0;
            this.Headerbar.UserName = "اسم المستخدم";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 43);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1120, 450);
            this.pnlContainer.TabIndex = 1;
            // 
            // frmMainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 493);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.Sidebar);
            this.DoubleBuffered = true;
            this.Name = "frmMainLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainLayout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserControls.ucSidebar Sidebar;
        private System.Windows.Forms.Panel pnlMain;
        private Controls.UserControls.ucHeaderbar Headerbar;
        private System.Windows.Forms.Panel pnlContainer;
    }
}