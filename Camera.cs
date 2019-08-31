using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.UI;


namespace Offocus
{
    
    public class Camera
    {
        string camIP;
        string User = "admin";
        string password;
        string Url;
        Shoot camshoot;
        public Camera (string Ip , string pass)
        {
            camIP = Ip;
            password = pass;
        }

       // will return a shoot as a Shoot object 
       public void GetShoot()
       {
            string camurl = $"rtsp://{User}:{password}@{camIP}:554/{Url}";
            VideoCapture img = new VideoCapture("camurl");
            if (img.IsOpened)
            {
                Mat Matrix = null;
                img.Read(Matrix);
                camshoot = new Shoot(Matrix);
                
            }
         
        }
       public Boolean CamStatus()
        {
            IPAddress iP = IPAddress.Parse(camIP);
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(iP, 554);
                return true;
            }
            catch (SocketException)
            {
                return false;
            }

        }
    }
}
