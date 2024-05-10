namespace MacroApp
{
    partial class Form2
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
            label1 = new Label();
            tbOperator = new TextBox();
            cBoxFunction = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Operador";
            // 
            // tbOperator
            // 
            tbOperator.Location = new Point(18, 47);
            tbOperator.Name = "tbOperator";
            tbOperator.Size = new Size(225, 27);
            tbOperator.TabIndex = 1;
            // 
            // cBoxFunction
            // 
            cBoxFunction.FormattingEnabled = true;
            cBoxFunction.Items.AddRange(new object[] { "Atacante", "Defensor" });
            cBoxFunction.Location = new Point(311, 47);
            cBoxFunction.Name = "cBoxFunction";
            cBoxFunction.Size = new Size(178, 28);
            cBoxFunction.TabIndex = 2;
            cBoxFunction.SelectedIndexChanged += cBoxFunction_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 24);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Função";
            // 
            // button1
            // 
            button1.Location = new Point(17, 452);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 510);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(cBoxFunction);
            Controls.Add(tbOperator);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbOperator;
        private ComboBox cBoxFunction;
        private Label label2;
        private Button button1;
    }
}