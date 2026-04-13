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

        [Description("Get clsResult.Success(string Message) if it is valid " +
            "or get clsResult.Failure(string Message) if it is not valid.")]
        public clsResult Valid()
        {
            if (Required && string.IsNullOrEmpty(cmbValues.Text))
            {
                return clsResult.Failure("Requried");
            }
            return clsResult.Success();
        }

        [Category("Custom Properties")]
        public string SelectedItem => cmbValues.SelectedItem?.ToString();

        [Description("Fill ComboBox")]
        public void SetValues(List<string> Values)
        {
            if(Values.Count > 0)
            {
                cmbValues.Items.Clear();
                foreach (string Value in Values)
                {
                    cmbValues.Items.Add(Value);
                }
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
