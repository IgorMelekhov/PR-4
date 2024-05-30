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

namespace PR_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            array.Validating += array_Validating;
        }
        private void array_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(array.Text))
            { errorProvider1.SetError(array, "Поле не может быть пустым!"); }
            //else if (string[] values = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);))
            //{errorProvider1.SetError(array, "В поле должно быть введено число!");}
            else
            { errorProvider1.Clear(); }
        }
        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            array.Clear();
            arrayBuble.Clear();
            arraySelect.Clear();
            arrayMerge.Clear();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            try
            {
                bool selectBuble = false;
                bool selectSelect = false;
                bool selectMerge=false;
                if (checkBuble.Checked) selectBuble = true;
                if (checkSelect.Checked) selectSelect = true;
                if (checkMerge.Checked) selectMerge = true;
                string input = array.Text;
                string[] values = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if ((Int32.TryParse(values[0], out _)))
                {
                    int[] intValue = new int[values.Length];
                    for (int i = 0; i < values.Length; i++)
                    {
                        intValue[i] = Convert.ToInt32(values[i]);
                    }
                    if (selectBuble )
                    {
                        Sort<int> sort = new Sort<int>(intValue);
                        arrayBuble.Text = sort.Get();
                    }
                    if (selectSelect )
                    {
                        int a = 0;
                        Sort<int> sort = new Sort<int>(intValue, a);
                        arraySelect.Text = sort.Get();
                    }
                    if (selectMerge)
                    {
                        int l = 0;
                        int r = intValue.Length - 1;
                        Sort<int> sort = new Sort<int>(intValue,l,r);
                        arrayMerge.Text = sort.Get();
                    }
                }
                else if (double.TryParse(values[0], out _))
                {
                    double[] doubleValue = new double[values.Length];
                    for (int i = 0; i < values.Length; i++)
                    {
                        doubleValue[i] = Convert.ToDouble(values[i]);
                    }
                    if (selectBuble)
                    {
                        Sort<double> sort = new Sort<double>(doubleValue);
                        arrayBuble.Text = sort.Get();
                    }
                    if (selectSelect)
                    {
                        int a = 0;
                        Sort<double> sort = new Sort<double>(doubleValue, a);
                        arraySelect.Text = sort.Get();
                    }
                    if (selectMerge)
                    {
                        int l = 0;
                        int r = doubleValue.Length - 1;
                        Sort<double> sort = new Sort<double>(doubleValue, l, r);
                        arrayMerge.Text = sort.Get();
                    }
                }
            }
            catch { }
        }
    }
}
