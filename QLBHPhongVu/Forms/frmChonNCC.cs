using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHPhongVu.Forms
{
    public partial class frmChonNCC : Form
    {
        public frmChonNCC()
        {
            InitializeComponent();
        }
        public int MANCC;
        private void frmChonNCC_Load(object sender, EventArgs e)
        {
            cboNCC.DataSource = NCCBL.GetInstance.GetDanhSachNCC();
            cboNCC.DisplayMember = "Tên NCC";
            cboNCC.ValueMember = "Mã NCC";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemNCC frm = new frmThemNCC();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                cboNCC.DataSource = NCCBL.GetInstance.GetDanhSachNCC();
                cboNCC.SelectedIndex = cboNCC.Items.Count - 1;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cboNCC.Items.Count > 0)
            {
                // Ensure there's a selected value
                if (cboNCC.SelectedValue != null)
                {
                    // Try to assign the selected value to MANCC
                    try
                    {
                        MANCC = (int)cboNCC.SelectedValue;
                        this.DialogResult = DialogResult.OK; // Set dialog result as OK
                    }
                    catch (InvalidCastException)
                    {
                        MessageBox.Show("Selected value could not be cast to an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // No item is selected, so prompt the user
                    MessageBox.Show("Please select a value from the dropdown.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // ComboBox has no items, so prompt the user
                MessageBox.Show("The ComboBox is not populated. Please check the data source.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
