using System;
using System.Windows.Forms;

namespace Hough_Digital_Image_Process_
{
    public partial class ValueSetting : Form
    {
        public ValueSetting()
        {
            InitializeComponent();
            button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public int nValue
        {
            get
            {
                return (Convert.ToInt32(Value.Text, 10));
            }
            set { Value.Text = value.ToString(); }
        }

        private void button_OK_DragEnter(object sender, DragEventArgs e)
        {
            button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
