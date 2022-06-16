using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Органайзер
{
    public partial class AddEditEvent : Form
    {
        public AddEditEvent()
        {
            InitializeComponent();
        }

        private void AddEditEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(tbxTime.Text);
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода времени наступления события!");
                    e.Cancel = true;
                    tbxTime.Focus();
                }

            }
        }
    }
}
