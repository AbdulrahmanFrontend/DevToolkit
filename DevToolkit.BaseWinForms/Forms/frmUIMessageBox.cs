using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevToolkit.Core.Common;
using DevToolkit.BaseWinForms.Models;
using DevToolkit.BaseWinForms.Utils;

namespace DevToolkit.BaseWinForms.Forms
{
    public partial class frmUIMessageBox : Form
    {
        public frmUIMessageBox(MessageBoxModel MessageBoxData)
        {
            InitializeComponent();
            _Initialize(MessageBoxData);
        }

        private void _Initialize(MessageBoxModel MessageBoxData)
        {
            lblMessage.Text = MessageBoxData.Message;
            lblMessage.MaximumSize = new Size(350, 0);
            lblMessage.AutoSize = true;
            _SetButtonsVisibility(MessageBoxData.Buttons);
            _ShowMessage(MessageBoxData);
        }

        private void _SetButtonsVisibility(MessageBoxButtons buttons)
        {
            btnOK.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    btnOK.Visible = true;
                    break;
                case MessageBoxButtons.YesNo:
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    break;
                default:
                    btnOK.Visible = true;
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    break;
            }
        }

        private void _ShowMessage(MessageBoxModel MessageBoxData)
        {
            switch (MessageBoxData.DialogType)
            {
                case DialogType.Success:
                    System.Media.SystemSounds.Asterisk.Play();
                    lblMessageCaption.Text = "Success";
                    pbIcon.Image = SystemIcons.Information.ToBitmap();
                    break;
                case DialogType.Error:
                    System.Media.SystemSounds.Hand.Play();
                    lblMessageCaption.Text = "Error";
                    pbIcon.Image = SystemIcons.Error.ToBitmap();
                    break;
                case DialogType.Warning:
                    System.Media.SystemSounds.Exclamation.Play();
                    lblMessageCaption.Text = "Warning";
                    pbIcon.Image = SystemIcons.Warning.ToBitmap();
                    break;
                case DialogType.Info:
                    System.Media.SystemSounds.Asterisk.Play();
                    lblMessageCaption.Text = "Information";
                    pbIcon.Image = SystemIcons.Information.ToBitmap();
                    break;
                case DialogType.Confirm:
                    System.Media.SystemSounds.Question.Play();
                    lblMessageCaption.Text = "Confirmation";
                    pbIcon.Image = SystemIcons.Question.ToBitmap();
                    break;
                default:
                    System.Media.SystemSounds.Asterisk.Play();
                    lblMessageCaption.Text = "Information";
                    pbIcon.Image = SystemIcons.Information.ToBitmap();
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void _DragMouseDown(object sender, MouseEventArgs e)
        {
            WindowDragHelper.DragMouseDown(sender, e);
        }

        private void _DragMouseMove(object sender, MouseEventArgs e)
        {
            WindowDragHelper.DragMouseMove(sender, e);
        }

        private void _DragMouseUp(object sender, MouseEventArgs e)
        {
            WindowDragHelper.DragMouseUp(sender, e);
        }
    }
}