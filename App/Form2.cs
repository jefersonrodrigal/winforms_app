using MacroApp.DbDataContext;
using MacroApp.Models;
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

namespace MacroApp
{
    public partial class Form2 : Form
    {
        private DataContext DbContext = new DataContext();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var newoperator = new Operator();

            newoperator.Name = tbOperator.Text;
            newoperator.Function = cBoxFunction.SelectedItem.ToString();

            DbContext.Add(newoperator);
            DbContext.SaveChanges();

            tbOperator.Text = "";
            cBoxFunction.SelectedIndex = -1;

            MessageBox.Show("Inserido com sucesso");
        }

        private void cBoxFunction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
