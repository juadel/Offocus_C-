using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Offocus
{
    public class Shoot
    {
        Image<Bgr,byte> image;
        string Clear_State;
        float Variance;
        float MaxVariance;
        float Scharr;
        float Noise;

        public Shoot(Mat img)
        {
            image = img.ToImage<Bgr, byte>();
        }  

        public void GetParameters()
        {
            Image<Bgr,float> laplace = image.Laplace(1);     
        } 

       // public void Check_blurry()
       // {

//        }

 //       public void Print_Shoot()
   //     {

     //   }
    }
}
