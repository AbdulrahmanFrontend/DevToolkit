using DevToolkit.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.Controls
{
    public partial class ucLabeledCombBox : UserControl
    {
        public ucLabeledCombBox()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public string LabelText
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Category("Custom Properties")]
        public Font ValuesFont
        {
            get => cmbValues.Font;
            set => cmbValues.Font = value;
        }

        [Category("Custom Properties")]
        public bool Required { get; set; } = false;

        [Category("Custom Properties")]
        public AutoCompleteMode AutoCompleteMode
        {
            get => cmbValues.AutoCompleteMode;
            set => cmbValues.AutoCompleteMode = value;
        }

        [Category("Custom Properties")]
        public AutoCompleteSource AutoCompleteSource
        {
            get => cmbValues.AutoCompleteSource;
            set => cmbValues.AutoCompleteSource = value;
        }

        [Category("Custom Properties")]
        public ComboBoxStyle DropDownStyle
        {
            get => cmbValues.DropDownStyle;
            set => cmbValues.DropDownStyle = value;
        }

        [Category("Custom Properties")]
        public bool Sorted
        {
            get => cmbValues.Sorted;
            set => cmbValues.Sorted = value;
        }

        [Category("Custom Properties")]
        public bool HasDefaultValue { get; set; } = false;

        [Category("Custom Properties")]
        public string DefaultValue { get; set; } = string.Empty;

        //[Category("Custom Properties")]
        public clsResult Valid()
        {
            if (Required && !string.IsNullOrEmpty(SelectedItem))
            {
                return clsResult.Success();
            }
            return clsResult.Failure("Required");
        }
        [Category("Custom Properties")]
        public string SelectedItem => cmbValues.SelectedItem?.ToString();

        //[Category("Custom Properties")]
        //public object SelectedValue => cmbValues.SelectedValue;

        //[Category("Custom Properties")]
        //public object DataSource
        //{
        //    get => cmbValues.DataSource;
        //    set => cmbValues.DataSource = value;
        //}

        //[Category("Custom Properties")]
        //public string DisplayMember
        //{
        //    get => cmbValues.DisplayMember;
        //    set => cmbValues.DisplayMember = value;
        //}

        //[Category("Custom Properties")]
        //public string ValueMember
        //{
        //    get => cmbValues.ValueMember;
        //    set => cmbValues.ValueMember = value;
        //}

        [Description("Fill ComboBox")]
        public void SetValues(IEnumerable<string> Values)
        {
            if(Values != null && Values.Any())
            {
                cmbValues.Items.Clear();
                cmbValues.Items.AddRange(Values.ToArray());
                if (HasDefaultValue)
                {
                    if (string.IsNullOrEmpty(DefaultValue))
                    {
                        cmbValues.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbValues.SelectedItem = DefaultValue;
                    }
                }
            }
        }
    }
}
