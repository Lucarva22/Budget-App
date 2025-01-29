using Projeto_BudgetApp.FinancialAppDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_BudgetApp
{
    public partial class ReceitaForm : Form
    {
        Form MenuF;
        bool gravar = true;
        public ReceitaForm(Form menu)
        {
            InitializeComponent();
            MenuF = menu;
        }

        private void ReceitaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialAppDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.financialAppDataSet.Categorias);
            // TODO: This line of code loads data into the 'financialAppDataSet.Pagamentos' table. You can move, or remove it, as needed.
            this.pagamentosTableAdapter.Fill(this.financialAppDataSet.Pagamentos);
            // TODO: This line of code loads data into the 'financialAppDataSet.Receitas' table. You can move, or remove it, as needed.
            this.receitasTableAdapter.Fill(this.financialAppDataSet.Receitas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gravar == false)
            {
                DialogResult res = MessageBox.Show("Quer sair sem gravar", "Informação", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                    MenuF.Controls["panel1"].Controls["btnReceita"].Enabled = true;
                }
                else if (res == DialogResult.No)
                {
                    this.Validate();
                    this.receitasBindingSource1.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.financialAppDataSet);

                    this.Close();
                    MenuF.Controls["panel1"].Controls["btnReceita"].Enabled = true;
                }
            }
            else
            {
                this.Close();
                MenuF.Controls["panel1"].Controls["btnReceita"].Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                receitasBindingSource1.RemoveCurrent();
                gravar = false;
            }
            catch
            {
                MessageBox.Show("Erro ao Apagar", "Informação!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receita despesa = new Receita();
            despesa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receitasBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialAppDataSet);
            gravar = true;
        }
    }
}
