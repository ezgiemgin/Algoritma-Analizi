using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sorting
{
    public partial class frmSorting : Form
    {
        public frmSorting()
        {
            InitializeComponent();
            dt.Columns.Add("Algoritma Adı");
            dt.Columns.Add("100", typeof(double));
            dt.Columns.Add("750", typeof(double));
            dt.Columns.Add("1500", typeof(double));
            dt.Columns.Add("7500", typeof(double));
            dt.Columns.Add("15000", typeof(double));
            dt.Columns.Add("75000", typeof(double));
            dt.Columns.Add("150000", typeof(double));


            dizi100 = RandomDataGenerator(dizi100);
            dizi750 = RandomDataGenerator(dizi750);
            dizi1500 = RandomDataGenerator(dizi1500);
            dizi7500 = RandomDataGenerator(dizi7500);
            dizi15000 = RandomDataGenerator(dizi15000);
            dizi75000 = RandomDataGenerator(dizi75000);
            dizi150000 = RandomDataGenerator(dizi150000);

            Array.Copy(dizi100, Copydizi100, dizi100.Length);
            Array.Copy(dizi750, Copydizi750, dizi750.Length);
            Array.Copy(dizi1500, Copydizi1500, dizi1500.Length);
            Array.Copy(dizi7500, Copydizi7500, dizi7500.Length);
            Array.Copy(dizi15000, Copydizi15000, dizi15000.Length);
            Array.Copy(dizi75000, Copydizi75000, dizi75000.Length);
            Array.Copy(dizi150000, Copydizi150000, dizi150000.Length);
            
            diziler.Add(dizi100);
            diziler.Add(dizi750);
            diziler.Add(dizi1500);
            diziler.Add(dizi7500);
            diziler.Add(dizi15000);
            diziler.Add(dizi75000);
            diziler.Add(dizi150000);
        }

        int[] dizi100 = new int[100];
        int[] dizi750 = new int[750];
        int[] dizi1500 = new int[1500];
        int[] dizi7500 = new int[7500];
        int[] dizi15000 = new int[15000];
        int[] dizi75000 = new int[75000];
        int[] dizi150000 = new int[150000];

        int[] Copydizi100 = new int[100];
        int[] Copydizi750 = new int[750];
        int[] Copydizi1500 = new int[1500];
        int[] Copydizi7500 = new int[7500];
        int[] Copydizi15000 = new int[15000];
        int[] Copydizi75000 = new int[75000];
        int[] Copydizi150000 = new int[150000];


        DataTable dt = new DataTable("Algoritma Karşılaştırma Sonuçları");
        List<int[]> diziler = new List<int[]>();
        DataRow dr;
        private void btn_Compare_Click(object sender, EventArgs e)
        {
            Array.Copy(Copydizi100, dizi100, dizi100.Length);
            Array.Copy(Copydizi750, dizi750, dizi750.Length);
            Array.Copy(Copydizi1500, dizi1500, dizi1500.Length);
            Array.Copy(Copydizi7500, dizi7500, dizi7500.Length);
            Array.Copy(Copydizi15000, dizi15000, dizi15000.Length);
            Array.Copy(Copydizi75000, dizi75000, dizi75000.Length);
            Array.Copy(Copydizi150000, dizi150000, dizi150000.Length);
                       
            
            SelectionSort SS = new SelectionSort();

            dr = dt.NewRow();
            dr[0]  = "Selection";
            for (int i = 0; i < diziler.Count; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                SS.SSort(diziler[i]);
                sw.Stop();
                dr[i + 1] = sw.Elapsed.TotalSeconds; 
            }
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
        }
        int[] RandomDataGenerator(int[] dizi)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(150000);
            }
            return dizi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Copy(Copydizi100, dizi100, dizi100.Length);
            Array.Copy(Copydizi750, dizi750, dizi750.Length);
            Array.Copy(Copydizi1500, dizi1500, dizi1500.Length);
            Array.Copy(Copydizi7500, dizi7500, dizi7500.Length);
            Array.Copy(Copydizi15000, dizi15000, dizi15000.Length);
            Array.Copy(Copydizi75000, dizi75000, dizi75000.Length);
            Array.Copy(Copydizi150000, dizi150000, dizi150000.Length);
            BubbleSort BS = new BubbleSort();

            DataRow dr = dt.NewRow();
            dr[0] = "Bubble";
            for (int i = 0; i < diziler.Count; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                BS.BSort(diziler[i]);
                sw.Stop();
                dr[i + 1] = sw.Elapsed.TotalSeconds; ;
            }
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Array.Copy(Copydizi100, dizi100, dizi100.Length);
            Array.Copy(Copydizi750, dizi750, dizi750.Length);
            Array.Copy(Copydizi1500, dizi1500, dizi1500.Length);
            Array.Copy(Copydizi7500, dizi7500, dizi7500.Length);
            Array.Copy(Copydizi15000, dizi15000, dizi15000.Length);
            Array.Copy(Copydizi75000, dizi75000, dizi75000.Length);
            Array.Copy(Copydizi150000, dizi150000, dizi150000.Length); 
            HeapSort HS = new HeapSort();
             dr = dt.NewRow();
            dr[0] = "Heap";
            for (int i = 0; i < diziler.Count; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                HS.HSort(diziler[i]);
                sw.Stop();
                dr[i + 1] = sw.Elapsed.TotalSeconds;
            }
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Copy(Copydizi100, dizi100, dizi100.Length);
            Array.Copy(Copydizi750, dizi750, dizi750.Length);
            Array.Copy(Copydizi1500, dizi1500, dizi1500.Length);
            Array.Copy(Copydizi7500, dizi7500, dizi7500.Length);
            Array.Copy(Copydizi15000, dizi15000, dizi15000.Length);
            Array.Copy(Copydizi75000, dizi75000, dizi75000.Length);
            Array.Copy(Copydizi150000, dizi150000, dizi150000.Length);
            InsertionSort IS = new InsertionSort();
            dr = dt.NewRow();
            dr[0] = "Insertion";
            for (int i = 0; i < diziler.Count; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                IS.ISort(diziler[i]);
                sw.Stop();
                dr[i + 1] = sw.Elapsed.TotalSeconds;
            }
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Copy(Copydizi100, dizi100, dizi100.Length);
            Array.Copy(Copydizi750, dizi750, dizi750.Length);
            Array.Copy(Copydizi1500, dizi1500, dizi1500.Length);
            Array.Copy(Copydizi7500, dizi7500, dizi7500.Length);
            Array.Copy(Copydizi15000, dizi15000, dizi15000.Length);
            Array.Copy(Copydizi75000, dizi75000, dizi75000.Length);
            Array.Copy(Copydizi150000, dizi150000, dizi150000.Length);
            QuickSort QS = new QuickSort();
            dr = dt.NewRow();
            dr[0] = "Quick";
            for (int i = 0; i < diziler.Count; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                QS.qSort(diziler[i]);
                sw.Stop();
                dr[i + 1] = sw.Elapsed.TotalSeconds;
            }
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
