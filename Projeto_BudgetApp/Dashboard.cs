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
    public partial class DashboardForm : Form
    {
        Form MenuF;
        int ValorR;
        int ValorD;

        int DespesasMes;
        int DespesasAno;

        int ReceitaMes;
        int ReceitaAno;
        public DashboardForm(Form f, int valorR, int valorD, int valorA, int valorM,int receitaM, int receitaA)
        {
            InitializeComponent();
            MenuF = f;
            ValorR = valorR;
            ValorD = valorD;


            DespesasMes = valorA;
            DespesasAno = valorM;

            ReceitaMes = receitaM;
            ReceitaAno = receitaA;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.receitasTableAdapter.Fill(this.financialAppDataSet.Receitas);

            label2.Text=ValorR.ToString();
            label4.Text=ValorD.ToString();


            label9.Text= DespesasMes.ToString();
            label13.Text = DespesasAno.ToString();

            label8.Text=ReceitaMes.ToString();
            label11.Text=ReceitaAno.ToString();

            int total = ReceitaAno - DespesasAno;
            if (total > 0)
            {
                label15.Text=total.ToString();
                label15.ForeColor=Color.Green;
            }
            else
            {
                label15.Text = total.ToString();
                label15.ForeColor = Color.Red;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuF.Controls["panel1"].Controls["btnDashboard"].Enabled = true;
        }

        private void receitasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receitasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialAppDataSet);

        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }
    }
}
