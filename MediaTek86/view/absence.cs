using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.view
{
    public partial class absence : Form
    {
        public absence()
        {
            InitializeComponent();
        }

        private void absence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediatek86DataSet2.service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.mediatek86DataSet2.service);
            // TODO: This line of code loads data into the 'mediatek86DataSet1.personnel' table. You can move, or remove it, as needed.
            this.personnelTableAdapter.Fill(this.mediatek86DataSet1.personnel);
            // TODO: This line of code loads data into the 'mediatek86DataSet.absence' table. You can move, or remove it, as needed.
            this.absenceTableAdapter.Fill(this.mediatek86DataSet.absence);

        }
    }
}
