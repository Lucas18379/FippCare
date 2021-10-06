using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FippCare
{
    public partial class frmDependentes : Form
    {
        DataTable dtDependente = new DataTable();
        DataRow drDependente;
        public frmDependentes()
        {
            InitializeComponent();
            drDependente = dtDependente.NewRow();
            drDependente = null;
        }
        public frmDependentes(DataTable dt)
        {
            InitializeComponent();
            drDependente = dtDependente.NewRow();
            drDependente = null;
        }
        public DataRow getDataRow()
        {
            return drDependente;
        }
        public DataTable getDataTable()
        {
            return dtDependente;
        }
        private void bSalvar_Click(object sender, EventArgs e)
        {
            dtDependente.Columns.Add("cpf", typeof(String));
            dtDependente.Columns.Add("nome", typeof(String));
            dtDependente.Columns.Add("sexo", typeof(String));
            dtDependente.Columns.Add("dtnasc", typeof(DateTime));
            dtDependente.Columns.Add("grauparent", typeof(String));
            drDependente = dtDependente.Rows.Add(mtbCPF.Text, tbNome.Text, cbSexo.Text, dtpDtNasc.Value, tbGrauParentesco.Text);
            Close();
        }
    }
}
