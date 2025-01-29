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
    public partial class Categorias : Form
    {
        Form MenuF;
        bool gravar = true;
        public Categorias(Form menuF)
        {
            InitializeComponent();
            MenuF = menuF;
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialAppDataSet);

        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialAppDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.financialAppDataSet.Categorias);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gravar == false)
            {
                DialogResult res = MessageBox.Show("Quer sair sem gravar", "Informação", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                    MenuF.Controls["panel1"].Controls["btnCategorias"].Enabled = true;
                }
                else if (res == DialogResult.No)
                {
                    this.Validate();
                    this.categoriasBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.financialAppDataSet);

                    this.Close();
                    MenuF.Controls["panel1"].Controls["btnCategorias"].Enabled = true;
                }
            }
            else
            {
                this.Close();
                MenuF.Controls["panel1"].Controls["btnCategorias"].Enabled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                categoriasBindingSource.RemoveCurrent();
                gravar = false;
            }
            catch
            {
                MessageBox.Show("Erro ao Apagar", "Informação!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialAppDataSet);
            gravar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Categoria = txtCategorias.Text;
                string Descricao = txtDescricao.Text;
                DateTime data = dataDateTimePicker.Value;
                categoriasTableAdapter.Insert(Categoria, Descricao, data);

                this.categoriasTableAdapter.Fill(this.financialAppDataSet.Categorias);
                MessageBox.Show("Introduzido com sucesso!", "Informação");

                txtCategorias.Text = "";
                txtDescricao.Text = "";
            }
            catch
            {
                MessageBox.Show("Algum valor introduzido de forma incorreta!", "Erro");
            }
        }
    }
}
