using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int[] a;
        Random rand;

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

     //   private void Form1_Shown(object sender, EventArgs e)
        {
            this.Height = grbBasic.Top + grbBasic.Height + 50;
            txtCount.Focus();
        }
      
        private void txtCount_TextChanged(object sender, EventArgs e)
        {

            grbTask.Visible = false;
            mnuTask.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
 private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (!examOnInt(txtCount))

                return;
            a = new int[Convert.ToInt32(txtCount.Text)];
            for (int i = 0; i < a.Length; i++)
                a[i] = rand.Next(-10, 10);
            output(grvBasic, a);
            mnuTask.Enabled = true;
            mnuArray.Enabled = true;
        }
        private bool examOnInt(TextBox txt)
        {

            try
            {
                Convert.ToInt32(txt.Text);

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Введите число!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
                return false;
            }
            return true;
        }
        private void output(DataGridView grv, int[] d)
        {
            grv.Rows.Clear();
            grv.RowCount = 1;
            grv.ColumnCount = d.Length;
            for (int i = 0; i < d.Length; i++)

            {
                grv.Columns[i].Name = (i + 1).ToString();
                grv.Columns[i].Width = 30;
                grv.Rows[0].Cells[i].Value = (d[i]).ToString();
            }
        }
        private void mnuTask_Click(object sender, EventArgs e)
        {
            grbTask.Top = grbBasic.Top + grbBasic.Height + 10;
            this.Height = grbTask.Top + grbTask.Height + 50;
            grbTask.Visible = true;
            txtC.Focus();
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtC.Text != "" & &e.KeyChar == 13)
                btnTask_Click(sender, e);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            int N, C, Summ; int[] array; Random r = new Random();
            N = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            array = new int[N];
            Summ = 0;
            for (int i = 0; i < array.Length; i++)
                array[i] = r.Next(-10, 10);
            for (int i = 0; i < array.Length; i++)
                if (array[i] > C)
                    Summ++;
        }
        private void init(ref int[] l)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > a[1])
                {
                    l = i;
                }
            }
            return;
        }
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            int N, l = 0, u, summ;
            Console.WriteLine("Работать с файлом? 1 - да, 2 - нет");
            u = Convert.ToInt32(Console.ReadLine());
            if (u == 2)
            {
                Console.WriteLine("Введите количество элементов");
                N = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[N];
                ar_input(array);
                summ = solve(array, l);
            }
        }
  private void mnuSave_Click(object sender, EventArgs e)
        {
            Summ = 0;
            for (int i = 0; i < array.Length; i++)
                array[i] = r.Next(-10, 10);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(reader.ReadLine());
                Console.Write(array[i] + "");
                if (array[i] > C)
                    Summ++;
                Console.WriteLine("Количество элементов массива=" + Summ);
                FileStream filel = new FileStream("D:\\Зачет\\Сохранить1.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(filel);
                Console.WriteLine("Количество элементов массива=" + Summ);
                Console.ReadLine();


            }
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }
