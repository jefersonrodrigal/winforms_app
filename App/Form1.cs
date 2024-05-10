using MacroApp.DbDataContext;
using MacroApp.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;


namespace MacroApp
{
    public partial class Form1 : Form
    {
        bool Running = true;
        bool EnabledRecoil = false;
        private DataContext DbContext;

        public Form1()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.DbContext = new DataContext();
            this.DbContext.Database.EnsureCreated();
            this.DbContext.Operators.Load();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.DbContext.Dispose();
            this.DbContext = null;
        }

        public void MouseMove()
        {
            int i = 0;
            while (Running)
            {
                Thread.Sleep(1);
                if (MouseClass.bGetAsyncKeyState(Keys.LButton) && EnabledRecoil && Convert.ToInt32(nUpDownIncressY.Value) != 0)
                {
                    MouseClass.Move(Convert.ToInt32(nUpDownStepX.Value), Convert.ToInt32(nUDowStepY.Value) + (Convert.ToInt32(nUpDownIncressY.Value) * i));
                    if ((Convert.ToInt32(nUDowStepY.Value) + (Convert.ToInt32(nUpDownIncressY.Value) * i)) < Convert.ToInt32(nUpDownMaxY.Value))
                        i++;
                }
                else if (MouseClass.bGetAsyncKeyState(Keys.LButton) && EnabledRecoil)
                {
                    MouseClass.Move(Convert.ToInt32(nUpDownStepX.Value), Convert.ToInt32(nUDowStepY.Value));
                }
                else
                {
                    i = 0;
                }
            }
        }


        public void Refresh_R()
        {
            while (Running)
            {
                Thread.Sleep(1);

                bool buffer = true;

                while (MouseClass.bGetAsyncKeyState(Keys.F2))
                {
                    if (buffer)
                    {
                        EnabledRecoil = !EnabledRecoil;
                        buffer = false;
                    }
                }

                if (EnabledRecoil)
                {
                    rbMEnable.Enabled = true;
                    rbMEnable.Checked = true;
                    rbMDisable.Enabled = false;
                    comboBox1.Enabled = false;
                    cBoxAttack.Enabled = false;
                    cBoxDefense.Enabled = false;
                    groupBoxY.Enabled = false;
                    groupBoxX.Enabled = false;
                    nUDowStepY.Enabled = false;
                    nUpDownIncressY.Enabled = false;
                    nUpDownMaxY.Enabled = false;
                    nUpDownStepX.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnReset.Enabled = false;
                    btnInserOperator.Enabled = false;
                }
                else
                {
                    rbMEnable.Enabled = false;
                    rbMDisable.Enabled = true;
                    rbMDisable.Checked = true;
                    comboBox1.Enabled = true;
                    cBoxAttack.Enabled = true;
                    cBoxDefense.Enabled = true;
                    groupBoxY.Enabled = true;
                    groupBoxX.Enabled = true;
                    nUDowStepY.Enabled = true;
                    nUpDownIncressY.Enabled = true;
                    nUpDownMaxY.Enabled = true;
                    nUpDownStepX.Enabled = true;
                    btnInserOperator.Enabled = true;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnReset.Enabled = true;
                }

                Thread.Sleep(1);
                buffer = true;
            }
        }

        private static void ExitApplication()
        {
            Process[] pname = Process.GetProcessesByName("MacroApp");
            if (pname.Length != 0)
            {
                foreach (Process process in pname)
                {
                    process.Kill();
                }
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread MoveMouseTH = new Thread(MouseMove);
            Thread RefreshTH = new Thread(Refresh_R);
            MoveMouseTH.Start();
            RefreshTH.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitApplication();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

            if (cBoxAttack.Checked)
            {
                comboBox1.Items.Clear();

                var result1 = DbContext.Operators.Where(x => x.Function == cBoxAttack.Text.Remove(cBoxAttack.Text.Length - 1))
                                                 .Select(x => x.Name);

                foreach (var item in result1)
                {
                    comboBox1.Items.Add(item.ToString());
                }

            }
            else if (cBoxDefense.Checked)
            {
                comboBox1.Items.Clear();

                var result2 = DbContext.Operators.Where(x => x.Function == cBoxDefense.Text.Remove(cBoxDefense.Text.Length - 2))
                                                 .Select(x => x.Name);

                foreach (var item in result2)
                {
                    comboBox1.Items.Add(item.ToString());
                }
            }

            if (cBoxAttack.Checked && cBoxDefense.Checked)
            {
                comboBox1.Items.Clear();


                var result3 = DbContext.Operators.Select(x => x.Name);

                foreach (var item in result3)
                {
                    comboBox1.Items.Add(item.ToString());
                }
            }

            if (!cBoxAttack.Checked && !cBoxDefense.Checked)
            {
                comboBox1.Items.Clear();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nUDowStepY.Value = 0;
            nUpDownIncressY.Value = 0;
            nUpDownMaxY.Value = 0;
            nUpDownStepX.Value = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = DbContext.Operators.First(x => x.Name == comboBox1.SelectedItem);

            result.StepY = Convert.ToInt32(nUDowStepY.Value);
            result.IncressY = Convert.ToInt32(nUpDownIncressY.Value);
            result.MaxY = Convert.ToInt32(nUpDownMaxY.Value);
            result.StepX = Convert.ToInt32(nUpDownStepX.Value);

            DbContext.Operators.Update(result);
            DbContext.SaveChanges();

            MessageBox.Show("Registro atualizado com sucesso");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = DbContext.Operators.First(x => x.Name == comboBox1.SelectedItem);
            DbContext.Operators.Remove(result);
            DbContext.SaveChanges();

            comboBox1.SelectedIndex = -1;

            nUDowStepY.Value = 0;
            nUpDownIncressY.Value = 0;
            nUpDownMaxY.Value = 0;
            nUpDownStepX.Value = 0;

            MessageBox.Show("Excluido com sucesso");

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var result = DbContext.Operators.First(x => x.Name == comboBox1.SelectedItem);
            nUDowStepY.Value = result.StepY;
            nUpDownIncressY.Value = result.IncressY;
            nUpDownMaxY.Value = result.MaxY;
            nUpDownStepX.Value = result.StepX;

        }

    }
}
