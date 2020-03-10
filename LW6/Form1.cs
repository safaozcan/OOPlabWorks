using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ozcan_4801BDA_LR6_1
{
    public partial class Form1 : Form
    {

        public ResultList result = new ResultList();
        string add, sub,comparelength,cl,s,a;
        double Xcoord1, Ycoord1, Zcoord1, Xcoord2, Ycoord2, Zcoord2;
        public class Result
        {
            public string add { get; set; }
            public string sub { get; set; }
            public string comparelength { get; set; }
            public Result(string a, string s,string cl)
            {
                add = a; sub = s;comparelength = cl; 
            }
        }

        public class ResultList : ArrayList, ITypedList
        {
           
            public PropertyDescriptorCollection
            GetItemProperties(PropertyDescriptor[] listAccessors)
            {
                return TypeDescriptor.GetProperties(typeof(Result));
            }
            
            public string GetListName(PropertyDescriptor[] listAccessors)
            {
                return "PersonList";
            }
        }

        public Form1()
        {
            InitializeComponent();
          
            dataGridView1.DataSource = new BindingSource(result, null);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
            dataGridView1.DataSource = result;
          
        }
        public String Add()
        {


            double sumx = 0.0;
            double sumy = 0.0;
            double sumz = 0.0;
            sumx = Xcoord1 + Xcoord2;
            sumy = Ycoord1 + Ycoord2;
            sumz = Zcoord1 + Zcoord2;


            return "(" + sumx + ", " + sumy + ", " + sumz + ")";

        }

        public String Sub()
        {

            double subx;
            double suby;
            double subz;
            subx = Xcoord1 - Xcoord2;
            suby = Ycoord1 - Ycoord2;
            subz = Zcoord1 - Zcoord2;


            return "(" + subx + ", " + suby + ", " + subz + ")";
        }
        public String Comparelength()
        {
            double l1, l2;
            l1 = Math.Sqrt((Xcoord1 * Xcoord1) + (Ycoord1 * Ycoord1) + (Zcoord1 * Zcoord1));
            l2 = Math.Sqrt((Xcoord2 * Xcoord2) + (Ycoord2 * Ycoord2) + (Zcoord2 * Zcoord2));
            if (l1 > l2)
            {
                return "Vector1>vector2";
            }
            if (l2 > l1)
            {
                return "Vector2>Vector1";
            }
            else
            {
                return "They are equal";
            }

        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            Xcoord1 = Convert.ToDouble(textBox1.Text);
            Ycoord1 = Convert.ToDouble(textBox2.Text);
            Zcoord1 = Convert.ToDouble(textBox3.Text);
            Xcoord2 = Convert.ToDouble(textBox4.Text);
            Ycoord2 = Convert.ToDouble(textBox5.Text);
            Zcoord2 = Convert.ToDouble(textBox6.Text);

            a = Add();
            s = Sub();
            cl = Comparelength();


            Result r = new Result(a, s, cl);
            result.Add(r);

            // JP
            dataGridView1.DataSource = result;
            //JP

            (BindingContext[result] as CurrencyManager).Refresh();
        }
        
    }
}
