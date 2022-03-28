using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLatihan1814
{
    public partial class FrmMahasiswa : Form
    {
        public FrmMahasiswa()
        {
            InitializeComponent();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (this.dgvMahasiswa.SelectedRows.Count > 0)
            {
                dgvMahasiswa.Rows.RemoveAt(this.dgvMahasiswa.SelectedRows[0].Index);
            };
        }
    }
}
