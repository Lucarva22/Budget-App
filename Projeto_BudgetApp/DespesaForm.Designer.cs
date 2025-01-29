namespace Projeto_BudgetApp
{
    partial class DespesaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.despesasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financialAppDataSet = new Projeto_BudgetApp.FinancialAppDataSet();
            this.despesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.despesaTableAdapter = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.DespesaTableAdapter();
            this.despesasTableAdapter = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.DespesasTableAdapter();
            this.pagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentosTableAdapter = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.PagamentosTableAdapter();
            this.despesasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasTableAdapter = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.CategoriasTableAdapter();
            this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(551, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 39);
            this.button3.TabIndex = 23;
            this.button3.Text = "Apagar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(250, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 39);
            this.button2.TabIndex = 22;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(675, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 49);
            this.label5.TabIndex = 20;
            this.label5.Text = "Despesas";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(427, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 39);
            this.button4.TabIndex = 25;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // despesasBindingSource1
            // 
            this.despesasBindingSource1.DataMember = "Despesas";
            this.despesasBindingSource1.DataSource = this.financialAppDataSet;
            // 
            // financialAppDataSet
            // 
            this.financialAppDataSet.DataSetName = "FinancialAppDataSet";
            this.financialAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // despesaBindingSource
            // 
            this.despesaBindingSource.DataMember = "Despesa";
            this.despesaBindingSource.DataSource = this.financialAppDataSet;
            // 
            // despesaTableAdapter
            // 
            this.despesaTableAdapter.ClearBeforeFill = true;
            // 
            // despesasTableAdapter
            // 
            this.despesasTableAdapter.ClearBeforeFill = true;
            // 
            // pagamentosBindingSource
            // 
            this.pagamentosBindingSource.DataMember = "Pagamentos";
            this.pagamentosBindingSource.DataSource = this.financialAppDataSet;
            // 
            // pagamentosTableAdapter
            // 
            this.pagamentosTableAdapter.ClearBeforeFill = true;
            // 
            // despesasDataGridView
            // 
            this.despesasDataGridView.AllowUserToAddRows = false;
            this.despesasDataGridView.AutoGenerateColumns = false;
            this.despesasDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.despesasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.despesasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.despesasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.despesasDataGridView.DataSource = this.despesasBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.despesasDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.despesasDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.despesasDataGridView.Location = new System.Drawing.Point(8, 52);
            this.despesasDataGridView.Name = "despesasDataGridView";
            this.despesasDataGridView.Size = new System.Drawing.Size(820, 295);
            this.despesasDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodDespesa";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodDespesa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CodCategorias";
            this.dataGridViewTextBoxColumn7.DataSource = this.categoriasBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn7.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "CodCategorias";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.financialAppDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CodPagamento";
            this.dataGridViewTextBoxColumn6.DataSource = this.pagamentosBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pagamento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "CodPagamento";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // despesasBindingSource
            // 
            this.despesasBindingSource.DataMember = "Despesas";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.DespesasTableAdapter = this.despesasTableAdapter;
            this.tableAdapterManager.DespesaTableAdapter = this.despesaTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PagamentosTableAdapter = this.pagamentosTableAdapter;
            this.tableAdapterManager.ReceitasTableAdapter = null;
            this.tableAdapterManager.ReceitaTableAdapter = null;
            this.tableAdapterManager.TransferenciasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_BudgetApp.FinancialAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DespesaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(840, 456);
            this.ControlBox = false;
            this.Controls.Add(this.despesasDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(842, 458);
            this.MinimumSize = new System.Drawing.Size(842, 458);
            this.Name = "DespesaForm";
            this.Load += new System.EventHandler(this.DespesaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource despesasBindingSource;
        private System.Windows.Forms.Button button4;
        private FinancialAppDataSet financialAppDataSet;
        private System.Windows.Forms.BindingSource despesaBindingSource;
        private FinancialAppDataSetTableAdapters.DespesaTableAdapter despesaTableAdapter;
        private System.Windows.Forms.BindingSource despesasBindingSource1;
        private FinancialAppDataSetTableAdapters.DespesasTableAdapter despesasTableAdapter;
        private System.Windows.Forms.BindingSource pagamentosBindingSource;
        private FinancialAppDataSetTableAdapters.PagamentosTableAdapter pagamentosTableAdapter;
        private System.Windows.Forms.DataGridView despesasDataGridView;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private FinancialAppDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private FinancialAppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}