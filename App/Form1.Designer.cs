namespace MacroApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxY = new GroupBox();
            nUpDownMaxY = new NumericUpDown();
            nUpDownIncressY = new NumericUpDown();
            nUDowStepY = new NumericUpDown();
            groupBoxX = new GroupBox();
            nUpDownStepX = new NumericUpDown();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnReset = new Button();
            btnUpdate = new Button();
            btnInserOperator = new Button();
            groupBox4 = new GroupBox();
            rbMDisable = new RadioButton();
            rbMEnable = new RadioButton();
            cBoxAttack = new CheckBox();
            cBoxDefense = new CheckBox();
            btnDelete = new Button();
            label2 = new Label();
            groupBoxY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUpDownMaxY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpDownIncressY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDowStepY).BeginInit();
            groupBoxX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUpDownStepX).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxY
            // 
            groupBoxY.Controls.Add(nUpDownMaxY);
            groupBoxY.Controls.Add(nUpDownIncressY);
            groupBoxY.Controls.Add(nUDowStepY);
            groupBoxY.Location = new Point(12, 67);
            groupBoxY.Name = "groupBoxY";
            groupBoxY.Size = new Size(503, 134);
            groupBoxY.TabIndex = 0;
            groupBoxY.TabStop = false;
            groupBoxY.Text = "Grau de Força Vertical  (Y)";
            // 
            // nUpDownMaxY
            // 
            nUpDownMaxY.Location = new Point(418, 101);
            nUpDownMaxY.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nUpDownMaxY.Name = "nUpDownMaxY";
            nUpDownMaxY.Size = new Size(79, 27);
            nUpDownMaxY.TabIndex = 2;
            // 
            // nUpDownIncressY
            // 
            nUpDownIncressY.Location = new Point(418, 59);
            nUpDownIncressY.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nUpDownIncressY.Name = "nUpDownIncressY";
            nUpDownIncressY.Size = new Size(79, 27);
            nUpDownIncressY.TabIndex = 1;
            // 
            // nUDowStepY
            // 
            nUDowStepY.Location = new Point(418, 17);
            nUDowStepY.Name = "nUDowStepY";
            nUDowStepY.Size = new Size(79, 27);
            nUDowStepY.TabIndex = 0;
            // 
            // groupBoxX
            // 
            groupBoxX.Controls.Add(nUpDownStepX);
            groupBoxX.Location = new Point(12, 207);
            groupBoxX.Name = "groupBoxX";
            groupBoxX.Size = new Size(503, 48);
            groupBoxX.TabIndex = 1;
            groupBoxX.TabStop = false;
            groupBoxX.Text = "Grau de Força Horizontal (X)";
            // 
            // nUpDownStepX
            // 
            nUpDownStepX.Location = new Point(418, 17);
            nUpDownStepX.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nUpDownStepX.Name = "nUpDownStepX";
            nUpDownStepX.Size = new Size(76, 27);
            nUpDownStepX.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 28);
            comboBox1.TabIndex = 2;
            comboBox1.DropDown += comboBox1_DropDown;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 3;
            label1.Text = "Operadores";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(209, 469);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(109, 469);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Alterar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInserOperator
            // 
            btnInserOperator.Location = new Point(362, 12);
            btnInserOperator.Name = "btnInserOperator";
            btnInserOperator.Size = new Size(153, 29);
            btnInserOperator.TabIndex = 7;
            btnInserOperator.Text = "Inserir Operador";
            btnInserOperator.UseVisualStyleBackColor = true;
            btnInserOperator.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbMDisable);
            groupBox4.Controls.Add(rbMEnable);
            groupBox4.Location = new Point(160, 307);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(153, 130);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Status Macro";
            // 
            // rbMDisable
            // 
            rbMDisable.AutoSize = true;
            rbMDisable.Checked = true;
            rbMDisable.Location = new Point(11, 87);
            rbMDisable.Name = "rbMDisable";
            rbMDisable.Size = new Size(115, 24);
            rbMDisable.TabIndex = 1;
            rbMDisable.TabStop = true;
            rbMDisable.Text = "Desabilitado";
            rbMDisable.UseVisualStyleBackColor = true;
            // 
            // rbMEnable
            // 
            rbMEnable.AutoSize = true;
            rbMEnable.Location = new Point(13, 28);
            rbMEnable.Name = "rbMEnable";
            rbMEnable.Size = new Size(101, 24);
            rbMEnable.TabIndex = 0;
            rbMEnable.Text = "Habilitado";
            rbMEnable.UseVisualStyleBackColor = true;
            // 
            // cBoxAttack
            // 
            cBoxAttack.AutoSize = true;
            cBoxAttack.Checked = true;
            cBoxAttack.CheckState = CheckState.Checked;
            cBoxAttack.Location = new Point(217, 12);
            cBoxAttack.Name = "cBoxAttack";
            cBoxAttack.Size = new Size(96, 24);
            cBoxAttack.TabIndex = 10;
            cBoxAttack.Text = "Atacantes";
            cBoxAttack.UseVisualStyleBackColor = true;
            // 
            // cBoxDefense
            // 
            cBoxDefense.AutoSize = true;
            cBoxDefense.Checked = true;
            cBoxDefense.CheckState = CheckState.Checked;
            cBoxDefense.Location = new Point(217, 36);
            cBoxDefense.Name = "cBoxDefense";
            cBoxDefense.Size = new Size(105, 24);
            cBoxDefense.TabIndex = 11;
            cBoxDefense.Text = "Defensores";
            cBoxDefense.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(9, 469);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Excluir";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 271);
            label2.Name = "label2";
            label2.Size = new Size(225, 20);
            label2.TabIndex = 13;
            label2.Text = "Pressione F2 Ativar / Desativar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 510);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(cBoxDefense);
            Controls.Add(cBoxAttack);
            Controls.Add(groupBox4);
            Controls.Add(btnInserOperator);
            Controls.Add(btnUpdate);
            Controls.Add(btnReset);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(groupBoxX);
            Controls.Add(groupBoxY);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBoxY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUpDownMaxY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpDownIncressY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDowStepY).EndInit();
            groupBoxX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUpDownStepX).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxY;
        private GroupBox groupBoxX;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnReset;
        private Button btnUpdate;
        private Button btnInserOperator;
        private GroupBox groupBox4;
        private RadioButton rbMDisable;
        private RadioButton rbMEnable;
        private NumericUpDown nUpDownMaxY;
        private NumericUpDown nUpDownIncressY;
        private NumericUpDown nUDowStepY;
        private NumericUpDown nUpDownStepX;
        private CheckBox cBoxAttack;
        private CheckBox cBoxDefense;
        private Button btnDelete;
        private Label label2;
    }
}
