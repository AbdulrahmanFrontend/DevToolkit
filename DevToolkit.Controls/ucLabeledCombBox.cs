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
        public AutoCompleteMode ComboBoxAutoCompleteMode
        {
            get => cmbValues.AutoCompleteMode;
            set => cmbValues.AutoCompleteMode = value;
        }

        [Category("Custom Properties")]
        public ComboBoxStyle ComboBoxDropDownStyle
        {
            get => cmbValues.DropDownStyle;
            set => cmbValues.DropDownStyle = value;
        }

        [Category("Custom Properties")]
        public bool SortedComboBoxItems
        {
            get => cmbValues.Sorted;
            set => cmbValues.Sorted = value;
        }

        // SortedSet stores unique elements in sorted order so it is faster than List, HashSet
        [Description("Sets the items of the ComboBox.")]
        public void SetComboBoxItems(SortedSet<string> Items)
        {
            if (Items.Count > 0)
            {
                cmbValues.Items.Clear();
                foreach (var Item in Items)
                {
                    if (Item != null)
                    {
                        cmbValues.Items.Add(Item);
                    }
                }
                cmbValues.SelectedIndex = 0;
            }
        }

        public Action<object> SelectItem;
        protected void OnSelectedItem(object Item)
        {
            Action<object> handler = SelectItem;
            if (handler != null)
            {
                handler(Item);
            }
        }

        private void CCCmBValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectItem != null)
            {
                OnSelectedItem(cmbValues.SelectedItem);
            }
        }
    }
}
