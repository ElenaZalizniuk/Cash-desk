using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WF_HT_6
{
    /// <summary>
    /// fields for work with constants:
    /// </summary>
    enum Nums : int { Minone = -1, Null, One, Two, Three };
    public partial class BestOil : Form
    {
      ///prices:
        static double A95 = 27.50;
        static double A92 = 26.80;
        static double A76 = 24.30;
        static double DT = 19.90;
        static double hotd = 45.00;
        static double gamb = 55.50;
        static double espr = 45.00;
        static double tea = 35.00;
        /// <summary>
        /// field for calculations
        /// </summary>
        string sumhd = null, sumgam = null, sumesp = null, sumtea = null;
        string Path = @"OfDay.txt";

        /// <summary>
        /// constructor
        /// </summary>
        public BestOil()
        {
            InitializeComponent();
            ///Formautosize
            this.Size = new Size(700, 650);
            ///Creating oilarray:
            this.cbOil.Items.AddRange(new object[] { "A-95", "A-92", "A-76", "ДТ" });
            this.cbOil.SelectedIndex = (int)Nums.Null;

        }
        /// <summary>
        /// adding price of selected oil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOil.SelectedIndex == (int)Nums.Null)
                this.lbproil.Text = A95.ToString();
            if (cbOil.SelectedIndex == (int)Nums.One)
                this.lbproil.Text = A92.ToString();
            if (cbOil.SelectedIndex == (int)Nums.Two)
                this.lbproil.Text = A76.ToString();
            if (cbOil.SelectedIndex == (int)Nums.Three)
                this.lbproil.Text = DT.ToString();

        }
        /// <summary>
        /// select oilamount in liters 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbamoil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbamoil.Checked)
            {
                this.nudhrn.Enabled = false;
                this.gbSumOil.Text = string.Format("Всего в грн:");
            }
            else
                this.nudhrn.Enabled = true;
            nudlitr.Value = (int)Nums.Null;
            this.lbOilSum.Text = nudlitr.Value.ToString();

        }
        /// <summary>
        /// select moneyamount in Hrn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbsum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsum.Checked)
            {
                this.nudlitr.Enabled = false;
                this.gbSumOil.Text = string.Format("Всего в литрах:");
            }
            else
            {
                this.nudlitr.Enabled = true;
                nudhrn.Value = (int)Nums.Null;
                this.lbOilSum.Text = nudhrn.Value.ToString();
            }
        }
        /// <summary>
        /// was choosed amount liters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudlitr_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbOil.SelectedIndex == (int)Nums.Null)
                    this.lbOilSum.Text = Math.Round((A95 * (double)nudlitr.Value), 2).ToString();
                if (cbOil.SelectedIndex == (int)Nums.One)
                    this.lbOilSum.Text = Math.Round((A92 * (double)nudlitr.Value), 2).ToString();
                if (cbOil.SelectedIndex == (int)Nums.Two)
                    this.lbOilSum.Text = Math.Round((A76 * (double)nudlitr.Value), 2).ToString();
                if (cbOil.SelectedIndex == (int)Nums.Three)
                    this.lbOilSum.Text = Math.Round((DT * (double)nudlitr.Value), 2).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// was choosed amount of money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudhrn_ValueChanged(object sender, EventArgs e)
        {
            if (cbOil.SelectedIndex == (int)Nums.Null)
                this.lbOilSum.Text = Math.Round(((double)nudhrn.Value / A95), 2).ToString();
            if (cbOil.SelectedIndex == (int)Nums.One)
                this.lbOilSum.Text = Math.Round(((double)nudhrn.Value / A92), 2).ToString();
            if (cbOil.SelectedIndex == (int)Nums.Two)
                this.lbOilSum.Text = Math.Round(((double)nudhrn.Value / A76), 2).ToString();
            if (cbOil.SelectedIndex == (int)Nums.Three)
                this.lbOilSum.Text = Math.Round(((double)nudhrn.Value / DT), 2).ToString();

        }
        /// <summary>
        /// event choosing of the HotDog
        /// calculation of the cost of the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudHotD_ValueChanged(object sender, EventArgs e)
        {
            sumhd = Math.Round(((double)nudHotD.Value * hotd), 2).ToString();
            this.lbHotD.Text = sumhd;
            if (!chbHotD.Checked)
                this.nudHotD.Value = (int)Nums.Null;
        }
        /// <summary>
        /// event choosing of the Gamburger
        /// calculation of the cost of the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudGamb_ValueChanged(object sender, EventArgs e)
        {
            sumgam = Math.Round(((double)nudGamb.Value * gamb), 2).ToString();
            this.lbGamb.Text = sumgam;
            if (!chbGamb.Checked)
                this.nudGamb.Value = (int)Nums.Null;
        }
        /// <summary>
        /// event choosing of the Espresso
        /// calculation of the cost of the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudEspr_ValueChanged(object sender, EventArgs e)
        {
            sumesp = Math.Round(((double)nudEspr.Value * espr), 2).ToString();
            this.lbEspr.Text = sumesp;
            if (!chbEspr.Checked)
                this.nudEspr.Value = (int)Nums.Null;
        }


        /// <summary>
        /// event choosing of the Tea
        /// calculation of the cost of the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudTea_ValueChanged(object sender, EventArgs e)
        {
            sumtea = Math.Round(((double)nudTea.Value * tea), 2).ToString();
            this.lbTea.Text = sumtea;
            if (!chbTea.Checked)
                this.nudTea.Value = (int)Nums.Null;
        }
        /// <summary>
        /// button for the calculation of the cost of the all goods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ///calling needed events for calculation
                nudHotD_ValueChanged(sender, e);
                nudGamb_ValueChanged(sender, e);
                nudEspr_ValueChanged(sender, e);
                nudTea_ValueChanged(sender, e);
                ///initialization short fields for calcilation
                var a = double.Parse(sumhd);
                var b = double.Parse(sumgam);
                var c = double.Parse(sumesp);
                var d = double.Parse(sumtea);
                ///Bill for a cafe
                this.lbProdSum.Text = (a + b + c + d).ToString();
                ///Bill for all goods
                this.lbGen.Text = (double.Parse(lbOilSum.Text) + double.Parse(lbProdSum.Text)).ToString();
                this.timer1.Interval = 10000;
                this.timer1.Enabled = true;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        /// <summary>
        /// Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 10000)//after 10 sec fills Question
            {
                var q = MessageBox.Show("Очистить данные?", "Вопрос", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (q == DialogResult.OK)//if clear
                {
                    btClear_Click(sender, e);//fill event button Clear
                    this.timer1.Enabled = false;//stop timer
                }
                else
                    this.timer1.Enabled = true;//if Cancel - timer works
            }

        }
        /// <summary>
        /// event of the button Clear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, EventArgs e)
        {
            try
            {
                //IterateControls(this);

                using (StreamWriter sw = File.AppendText(Path))
                {
                    sw.WriteLine(this.lbGen.Text);
                }
                Application.Restart();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        /// <summary>
        /// method for dataclear
        /// </summary>
        /// <param name="ctrl"></param>
        private void IterateControls(Control ctrl)
        {
            try
            {
                if (ctrl.GetType() == typeof(NumericUpDown) 
                    || ctrl.GetType() == typeof(RadioButton)
                    || ctrl.GetType() == typeof(Label))
                {
                    ctrl.ResetText();
                }
                ///go throw the containers:
                foreach (Control ctrlChild in ctrl.Controls)
                {
                    IterateControls(ctrlChild);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        /// <summary>
        /// total revenues
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                if (Path != null)
                {
                    string[] allLines = File.ReadAllLines(this.Path);
                    for (var i = (int)Nums.Null; i < allLines.Length; i++)
                    {
                        lbDay.Items.Add(allLines[i]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
