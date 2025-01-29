using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_BudgetApp
{
    public partial class FormMenu : Form
    {
        
        public FormMenu(string login)
        {
          InitializeComponent();
          lblLogin.Text = login;
        }
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceitaForm conf = new ReceitaForm(this);
            conf.TopLevel = false; 
            conf.FormBorderStyle = FormBorderStyle.None; 
            conf.Dock = DockStyle.Fill; 

            panel2.Controls.Add(conf);
            conf.Show();
            btnReceita.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DespesaForm conf = new DespesaForm(this);
            conf.TopLevel = false; 
            conf.FormBorderStyle = FormBorderStyle.None; 
            conf.Dock = DockStyle.Fill;

            panel2.Controls.Add(conf);
            conf.Show();
            btnDespesas.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialAppDataSet.Despesas' table. You can move, or remove it, as needed.
            this.despesasTableAdapter.Fill(this.financialAppDataSet.Despesas);
            // TODO: This line of code loads data into the 'financialAppDataSet.Receitas' table. You can move, or remove it, as needed.
            this.receitasTableAdapter.Fill(this.financialAppDataSet.Receitas);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categorias conf = new Categorias(this);
            conf.TopLevel = false;
            conf.FormBorderStyle = FormBorderStyle.None;
            conf.Dock = DockStyle.Fill;

            panel2.Controls.Add(conf);

            conf.Show();
            btnCategorias.Enabled = false;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Receita = (int)this.receitasTableAdapter.ScalarQuery();
            int ReceitaMes = (int)this.receitasTableAdapter.Ultimos30diasReceita();
            int ReceitaAno = (int)this.receitasTableAdapter.UltimoAnoReceita();

            int Despesas = (int)this.despesasTableAdapter.DespesasQuery();
            int DespesasMes = (int)this.despesasTableAdapter.Ultimos30diasQuery();
            int DespesasAno = (int)this.despesasTableAdapter.UltimoAnoQuery();


            DashboardForm conf = new DashboardForm(this, Receita, Despesas, DespesasMes, DespesasAno, ReceitaMes, ReceitaAno);
            conf.TopLevel = false;
            conf.FormBorderStyle = FormBorderStyle.None;
            conf.Dock = DockStyle.Fill;

            panel2.Controls.Add(conf);

            conf.Show();
            btnDashboard.Enabled = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Pagamentos conf = new Pagamentos(this);
            conf.TopLevel = false;
            conf.FormBorderStyle = FormBorderStyle.None;
            conf.Dock = DockStyle.Fill;

            panel2.Controls.Add(conf);

            conf.Show();
            btnPagamentos.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void receitasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receitasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialAppDataSet);

        }
    }
}
