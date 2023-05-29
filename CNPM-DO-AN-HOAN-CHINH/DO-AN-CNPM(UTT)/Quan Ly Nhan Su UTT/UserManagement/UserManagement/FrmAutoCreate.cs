using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class FrmAutoCreate : Form
    {

        public int Quantity { get; set; }

        public FrmAutoCreate()
        {
            InitializeComponent();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int check = int.Parse(txtQuantity.Text);
                if(check <= 0)
                {
                    MessageBox.Show("số nhân viên được tạo tự động phải lớn hơn 0");
                    return;
                }
                this.Quantity = check;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Số lượng nhân viên muốn tự động tạo không hợp lệ");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
