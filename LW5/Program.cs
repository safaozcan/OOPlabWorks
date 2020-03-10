using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Özcan_4801BDA_LR2_1
{
    public abstract class Vector3Dtest
    {

        public abstract string Add();


    }
    public class Vector3D : Vector3Dtest
    {

        public double Xcoord1;
        public double Ycoord1;
        public double Zcoord1;
        public double Xcoord2;
        public double Ycoord2;
        public double Zcoord2;
        public Vector3D()
        {
            Xcoord1 = 1.0;
            Ycoord1 = 2.0;
            Zcoord1 = 3.0;
            Xcoord2 = 3.0;
            Ycoord2 = 2.0;
            Zcoord2 = 1.0;
        }
        public Vector3D(double Xcoord1, double Xcoord2, double Ycoord1, double Ycoord2, double Zcoord1, double Zcoord2)
        {
            this.Xcoord1 = Xcoord1;
            this.Ycoord1 = Ycoord1;
            this.Zcoord1 = Zcoord1;
            this.Xcoord2 = Xcoord2;
            this.Ycoord2 = Ycoord2;
            this.Zcoord2 = Zcoord2;
        }

        public override string Add()
        {


            double sumx = 0.0;
            double sumy = 0.0;
            double sumz = 0.0;
            sumx = Xcoord1 + Xcoord2;
            sumy = Ycoord1 + Ycoord2;
            sumz = Zcoord1 + Zcoord2;


            return "(" + sumx + ", " + sumy + ", " + sumz + ")";

        }

        public string Sub()
        {

            double subx;
            double suby;
            double subz;
            subx = Xcoord1 - Xcoord2;
            suby = Ycoord1 - Ycoord2;
            subz = Zcoord1 - Zcoord2;


            return "(" + subx + ", " + suby + ", " + subz + ")";
        }
        public string ScalerPro()
        {

            double product;
            product = Xcoord1 * Xcoord2 + Ycoord1 * Ycoord2 + (Zcoord1 + Zcoord2);

            return "" + product;

        }
        public string Multi()
        {
            double a;
            double mulx1 = 0, muly1 = 0, mulz1 = 0, mulx2, muly2, mulz2;
            Console.WriteLine("Enter a scaler: ");
            a = Convert.ToDouble(Console.ReadLine());
            mulx1 = Xcoord1 * a;
            muly1 = Ycoord1 * a;
            mulz1 = Zcoord1 * a;
            mulx2 = Xcoord2 * a;
            muly2 = Ycoord2 * a;
            mulz2 = Zcoord2 * a;





            return "For the first vector: (" + mulx1 + ", " + muly1 + ", " + mulz1 + ")" + "\nFor the second vector: (" + mulx2 + ", " + muly2 + ", " + mulz2 + ")";
        }
        public string Multi(double a)
        {

            double mulx1 = 0, muly1 = 0, mulz1 = 0, mulx2, muly2, mulz2;

            mulx1 = Xcoord1 * a;
            muly1 = Ycoord1 * a;
            mulz1 = Zcoord1 * a;
            mulx2 = Xcoord2 * a;
            muly2 = Ycoord2 * a;
            mulz2 = Zcoord2 * a;





            return " This is the second multi method \n For the first vector: (" + mulx1 + ", " + muly1 + ", " + mulz1 + ")" + "\nFor the second vector: (" + mulx2 + ", " + muly2 + ", " + mulz2 + ")";
        }
        public string Length()
        {
            double l1, l2;
            l1 = Math.Sqrt(Xcoord1 * Xcoord1 + Ycoord1 * Ycoord1 + Zcoord1 * Zcoord1);
            l2 = Math.Sqrt(Xcoord2 * Xcoord2 + Ycoord2 * Ycoord2 + Zcoord2 * Zcoord2);

            return "Length of the first vector= " + l1 + "\tLength of the second vector= " + l2;
        }
        public string Comparelength()
        {
            double l1, l2;
            l1 = Math.Sqrt(Xcoord1 * Xcoord1 + Ycoord1 * Ycoord1 + Zcoord1 * Zcoord1);
            l2 = Math.Sqrt(Xcoord2 * Xcoord2 + Ycoord2 * Ycoord2 + Zcoord2 * Zcoord2);
            if (l1 > l2)
            {
                return "First vector bigger than second.";
            }
            if (l2 > l1)
            {
                return "Second vector bigger than first.";
            }
            else
            {
                return "They are equal.";
            }



        }
        public string Comparisson()
        {
            if (Xcoord1 != Xcoord2 || Ycoord1 != Ycoord2 || Zcoord1 != Zcoord2)
            {
                return "They are two differet vectors.";
            }
            else
            {
                return "They are equal.";
            }


        }



        public class Vectors3DTest
        {
            public static void Main()
            {

                try
                {
                    int a, b = 0;
                    if (b == 0)
                    {
                        throw new UserException();
                    }
                    else
                    {
                        a = 2 / b;
                    }
                }
                catch (UserException e)
                {
                    Console.WriteLine("\n \t User exception \n");
                }

                double x1, y1, z1, x2, y2, z2;

                Console.WriteLine("----------First Vector---------- ");
                Console.WriteLine("Enter the length of the Xcoord: ");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of the Ycoord: ");
                y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of the Zcoord: ");
                z1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("----------Second Vector---------- ");
                Console.WriteLine("Enter the length of the Xcoord: ");
                x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of the Ycoord: ");
                y2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of the Zcoord: ");
                z2 = Convert.ToDouble(Console.ReadLine());


                Vector3D v1 = new Vector3D(x1, x2, y1, y2, z1, z2);
                Vector3D v2 = new Vector3D();

                Dispatcher d = new Dispatcher();

                d.VEvent += new Dispatcher.Vector3DHandler(v1.Add);
                d.VEvent += new Dispatcher.Vector3DHandler(v1.Sub);
                d.VEvent += new Dispatcher.Vector3DHandler(v1.ScalerPro);
                d.VEvent += new Dispatcher.Vector3DHandler(v1.Multi);
                d.VEvent += new Dispatcher.Vector3DHandler(v1.Length);
                d.VEvent += new Dispatcher.Vector3DHandler(v1.Comparelength);
                d.VEvent += new Dispatcher.Vector3DHandler(v1.Comparisson);
                d.VCommand();
                d.VEvent -= new Dispatcher.Vector3DHandler(v1.Add);
                d.VEvent -= new Dispatcher.Vector3DHandler(v1.Sub);
                d.VEvent -= new Dispatcher.Vector3DHandler(v1.ScalerPro);
                d.VEvent -= new Dispatcher.Vector3DHandler(v1.Multi);
                d.VEvent -= new Dispatcher.Vector3DHandler(v1.Length);
                d.VEvent -= new Dispatcher.Vector3DHandler(v1.Comparelength);
                d.VEvent -= new Dispatcher.Vector3DHandler(v1.Comparisson);


                Console.WriteLine("Sum of two vectors ={0}", v2.Add());
                Console.WriteLine("Sub of two vectors = {0}", v2.Sub());
                Console.WriteLine("Scaler productation = {0}", v2.ScalerPro());
                Console.WriteLine("Scaler multiplication = {0}", v2.Multi());
                Console.WriteLine("Scaler multiplication = {0}", v2.Multi(3.0));
                Console.WriteLine(v2.Length());
                Console.WriteLine(v2.Comparelength());
                Console.WriteLine(v2.Comparisson());


                Console.ReadLine();
            }


        }


    }
    public class Dispatcher
    {
        public delegate string Vector3DHandler();

        public event Vector3DHandler VEvent;

        public void VCommand()
        {
            if (VEvent != null)
            {
                VEvent();
            }
        }
    }
    public class UserException : Exception
    {
        public UserException()
        {

        }
    }


}


