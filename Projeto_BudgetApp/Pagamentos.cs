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
    public partial class Pagamentos : Form
    {
        Form MenuF;
        bool gravar = true;
        public Pagamentos(Form menuF)
        {
            InitializeComponent();
            MenuF = menuF;
        }

        private void Pagamentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialAppDataSet.Pagamentos' table. You can move, or remove it, as needed.
            this.pagamentosTableAdapter.Fill(this.financialAppDataSet.Pagamentos);

        }

        private void pagamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pagamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialAppDataSet);

        }

        private void pagamentosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gravar == false)
            {
                DialogResult res = MessageBox.Show("Quer sair sem gravar", "Informação", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                    MenuF.Controls["panel1"].Controls["btnPagamentos"].Enabled = true;
                }
                else if (res == DialogResult.No)
                {
                    this.Validate();
                    this.pagamentosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.financialAppDataSet);

                    this.Close();
                    MenuF.Controls["panel1"].Controls["btnPagamentos"].Enabled = true;
                }
            }
            else
            {
                this.Close();
                MenuF.Controls["panel1"].Controls["btnPagamentos"].Enabled = true;
            }
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pagamentosBindingSource.RemoveCurrent();
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
            this.pagamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialAppDataSet);
            gravar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Metodo = txtPagamentos.Text;
                string Descricao = txtDescricao.Text;
                DateTime data = dataDateTimePicker.Value;
                pagamentosTableAdapter.Insert(Metodo,Descricao,data);

                this.pagamentosTableAdapter.Fill(this.financialAppDataSet.Pagamentos);
                MessageBox.Show("Introduzido com sucesso!", "Informação");

                txtPagamentos.Text = "";
            }
            catch
            {
                MessageBox.Show("Algum valor introduzido de forma incorreta!", "Erro");
            }


        }
    }
}
