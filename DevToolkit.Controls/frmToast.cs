using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevToolkit.Controls.Utils;
using DevToolkit.Core;
using DevToolkit.Controls.Properties;

namespace DevToolkit.Controls
{
    public partial class frmToast : Form
    {
        public frmToast(clsToastData ToastData)
        {
            InitializeComponent();
            this.TopMost = true;
            _Initialize(ToastData);
        }

        private enum _enAction
        {
            wait,
            start,
            close
        }

        private _enAction _action;

        private int _x, _y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this._action)
            {
                case _enAction.wait:
                    timer1.Interval = 2000;
                    _action = _enAction.close;
                    break;
                case frmToast._enAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this._x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            _action = frmToast._enAction.wait;
                        }
                    }
                    break;
                case _enAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                        timer1.Stop();
                        _ActiveToasts.Remove(this);
                    }
                    break;
            }
        }

        private static List<frmToast> _ActiveToasts = new List<frmToast>();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            _ActiveToasts.Remove(this);
        }

        private void _SetPosition()
        {
            _ActiveToasts.Add(this);
            int i = _ActiveToasts.Count;
            this._x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
            this._y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
            this.Location = new Point(this._x, this._y);
            this._x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
        }

        private void _Initialize(clsToastData ToastData)
        {
            this.lblMsg.Text = ToastData.Message;
            
            Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            
            _SetPosition();

            _ShowMessage(ToastData);

            this.Show();
            this._action = _enAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        private void _ShowMessage(clsToastData ToastData)
        {
            switch (ToastData.DialogType)
            {
                case clsEnums.enDialogType.enSuccess:
                    System.Media.SystemSounds.Asterisk.Play();
                    this.BackColor = Color.SeaGreen;
                    this.pbIcon.Image = Resources.icons8_checkmark_36;
                    break;
                case clsEnums.enDialogType.enError:
                    System.Media.SystemSounds.Hand.Play();
                    this.BackColor = Color.DarkRed;
                    this.pbIcon.Image = Resources.icons8_close_36;
                    break;
                case clsEnums.enDialogType.enWarning:
                    System.Media.SystemSounds.Exclamation.Play();
                    this.BackColor = Color.DarkOrange;
                    this.pbIcon.Image = Resources.icons8_brake_warning_36;
                    break;
                case clsEnums.enDialogType.enInfo:
                    System.Media.SystemSounds.Asterisk.Play();
                    this.BackColor = Color.DodgerBlue;
                    this.pbIcon.Image = Resources.icons8_information_50;
                    break;
                default:
                    System.Media.SystemSounds.Asterisk.Play();
                    this.BackColor = Color.DodgerBlue;
                    this.pbIcon.Image = Resources.icons8_information_50;
                    break;
            }
        }
    }
}