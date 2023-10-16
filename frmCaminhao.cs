using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeFronta
{
    public partial class frmCaminhao : Form
    {
        public frmCaminhao()
        {
            InitializeComponent();
        }

        private void cAMINHAOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cAMINHAOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controleFrotaDataSet);

        }

        private void frmCaminhao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controleFrotaDataSet.CAMINHAO'. Você pode movê-la ou removê-la conforme necessário.
            this.cAMINHAOTableAdapter.Fill(this.controleFrotaDataSet.CAMINHAO);

        }

        private void cAMINHAODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
