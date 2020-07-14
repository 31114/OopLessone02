using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void memoTebleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memoTebleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202034DataSet);

        }

        private void memoTebleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.memoTebleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202034DataSet);

        }

        private void memoTebleBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.memoTebleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202034DataSet);

        }

        private void memoTebleBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.memoTebleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202034DataSet);

        }

        private void memoTebleBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.memoTebleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202034DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202034DataSet.memoTeble' テーブルに読み込みます。必要に応じて移動、または削除をしてください。

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.memoTebleTableAdapter.Fill(this.infosys202034DataSet.memoTeble);

        }
    }
}
