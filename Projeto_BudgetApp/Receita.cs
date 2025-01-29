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

namespace Projeto_BudgetApp
{
    public partial class Receita : Form
    {
        public Receita()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void receitasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receitasBindingSource.EndEdit();

        }

        private void Receita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialAppDataSet.Pagamentos' table. You can move, or remove it, as needed.
            this.pagamentosTableAdapter.Fill(this.financialAppDataSet.Pagamentos);
            // TODO: This line of code loads data into the 'financialAppDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.financialAppDataSet.Categorias);
            // TODO: This line of code loads data into the 'financialAppDataSet.Receitas' table. You can move, or remove it, as needed.
            this.receitasTableAdapter.Fill(this.financialAppDataSet.Receitas);
            // TODO: This line of code loads data into the 'financialAppDataSet.Receitas' table. You can move, or remove it, as needed.
            this.receitasTableAdapter.Fill(this.financialAppDataSet.Receitas);
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                short valor=Convert.ToInt16(txtValor.Text);
                string nome=txtNome.Text;
                string categoria = "";
                DateTime data = dateTimePicker1.Value;
                int pagamento = Convert.ToInt16(comboBox1.SelectedValue);
                int categorias = Convert.ToInt16(comboBox2.SelectedValue);

                receitasTableAdapter.Insert(valor, nome, categoria, data, pagamento, categorias);
                this.receitasTableAdapter.Fill(this.financialAppDataSet.Receitas);

                MessageBox.Show("Introduzido com sucesso!", "Informação");

                txtValor.Text = "";
                txtNome.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Algum valor introduzido de forma errada!", "Erro");
            }
        }

        private void receitasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.receitasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialAppDataSet);

        }
    }
}
