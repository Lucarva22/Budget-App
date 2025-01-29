using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_BudgetApp
{
    public partial class DespesaForm : Form
    {
        Form MenuF;
        bool gravar = true;
        public DespesaForm(Form menu)
        {
            InitializeComponent();
            MenuF = menu;
        }

        private void DespesaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialAppDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.financialAppDataSet.Categorias);
            // TODO: This line of code loads data into the 'financialAppDataSet.Pagamentos' table. You can move, or remove it, as needed.
            this.pagamentosTableAdapter.Fill(this.financialAppDataSet.Pagamentos);
            // TODO: This line of code loads data into the 'financialAppDataSet.Despesas' table. You can move, or remove it, as needed.
            this.despesasTableAdapter.Fill(this.financialAppDataSet.Despesas);
            // TODO: This line of code loads data into the 'financialAppDataSet.Despesa' table. You can move, or remove it, as needed.
            this.despesaTableAdapter.Fill(this.financialAppDataSet.Despesa);

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.despesasBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialAppDataSet);
            gravar= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gravar == false)
            {
                DialogResult res = MessageBox.Show("Quer sair sem gravar", "Informação", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                    MenuF.Controls["panel1"].Controls["btnDespesas"].Enabled = true;
                }
                else if (res == DialogResult.No)
                {
                    this.Validate();
                    this.despesasBindingSource1.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.financialAppDataSet);

                    this.Close();
                    MenuF.Controls["panel1"].Controls["btnDespesas"].Enabled = true;
                }
            }
            else
            {
                this.Close();
                MenuF.Controls["panel1"].Controls["btnDespesas"].Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                despesasBindingSource1.RemoveCurrent();
                gravar = false;
            }
            catch
            {
                MessageBox.Show("Erro ao Apagar", "Informação!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Despesa despesa = new Despesa();
            despesa.Show();
        }
    }
}
