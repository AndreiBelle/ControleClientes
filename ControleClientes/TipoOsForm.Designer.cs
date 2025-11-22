namespace ControleClientes
{
    partial class TipoOsForm
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
            comboBoxTipo = new ComboBox();
            buttonCancelTipo = new Button();
            buttonSalvarTipo = new Button();
            buttonExcluirTipo = new Button();
            textBoxValor = new TextBox();
            labelValor = new Label();
            labelTipo = new Label();
            SuspendLayout();
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(32, 37);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(151, 28);
            comboBoxTipo.TabIndex = 0;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // buttonCancelTipo
            // 
            buttonCancelTipo.Image = Properties.Resources.cross_circle;
            buttonCancelTipo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelTipo.Location = new Point(685, 214);
            buttonCancelTipo.Margin = new Padding(3, 4, 3, 4);
            buttonCancelTipo.Name = "buttonCancelTipo";
            buttonCancelTipo.Size = new Size(96, 31);
            buttonCancelTipo.TabIndex = 3;
            buttonCancelTipo.Text = "&Cancelar";
            buttonCancelTipo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelTipo.UseVisualStyleBackColor = true;
            buttonCancelTipo.Click += buttonCancelTipo_Click;
            // 
            // buttonSalvarTipo
            // 
            buttonSalvarTipo.Image = Properties.Resources.floppy_disk_circle_arrow_right;
            buttonSalvarTipo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarTipo.Location = new Point(576, 214);
            buttonSalvarTipo.Margin = new Padding(3, 4, 3, 4);
            buttonSalvarTipo.Name = "buttonSalvarTipo";
            buttonSalvarTipo.Size = new Size(103, 31);
            buttonSalvarTipo.TabIndex = 2;
            buttonSalvarTipo.Text = "&Salvar";
            buttonSalvarTipo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvarTipo.UseVisualStyleBackColor = true;
            buttonSalvarTipo.Click += buttonSalvarTipo_Click;
            // 
            // buttonExcluirTipo
            // 
            buttonExcluirTipo.Image = Properties.Resources.trash_xmark__1_;
            buttonExcluirTipo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluirTipo.Location = new Point(20, 214);
            buttonExcluirTipo.Margin = new Padding(3, 4, 3, 4);
            buttonExcluirTipo.Name = "buttonExcluirTipo";
            buttonExcluirTipo.Size = new Size(97, 31);
            buttonExcluirTipo.TabIndex = 4;
            buttonExcluirTipo.Text = "  &Excluir";
            buttonExcluirTipo.UseVisualStyleBackColor = true;
            buttonExcluirTipo.Click += buttonExcluirTipo_Click;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(32, 112);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(144, 27);
            textBoxValor.TabIndex = 1;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(32, 89);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(43, 20);
            labelValor.TabIndex = 22;
            labelValor.Text = "Valor";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(32, 14);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(112, 20);
            labelTipo.TabIndex = 21;
            labelTipo.Text = "Tipo de Serviço";
            // 
            // TipoOsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxTipo);
            Controls.Add(buttonCancelTipo);
            Controls.Add(buttonSalvarTipo);
            Controls.Add(buttonExcluirTipo);
            Controls.Add(textBoxValor);
            Controls.Add(labelValor);
            Controls.Add(labelTipo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TipoOsForm";
            Text = "TipoOsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipo;
        private Button buttonCancelTipo;
        private Button buttonSalvarTipo;
        private Button buttonExcluirTipo;
        private TextBox textBoxValor;
        private Label labelValor;
        private Label labelTipo;
    }
}