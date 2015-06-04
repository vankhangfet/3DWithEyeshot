using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Translators;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Porject3D
{
   public class Utility3D
    {

       public static void Scale(ReadFileAsynch rfa,  double scaleFactor)
       {
           
               foreach (Entity en in rfa.Entities)
               {
                   
                        en.Scale(scaleFactor, scaleFactor, scaleFactor);
                   
                   
               }
          

       }


       public static void Rotate(ReadFileAsynch rfa,  double angleRadian, Vector3D axis)
       {
           foreach (Entity en in rfa.Entities)
           {
               en.Rotate(angleRadian, axis);
           }

       }


       public static void Transalte(ReadFileAsynch rfa,  double dx, double dy, double dz)
       {
           foreach (Entity en in rfa.Entities)
           {
               en.Translate(dx, dy, dz);

           }

       }

       public static void CreateLayout(ViewportLayout viewport)
       {
           viewport.Layers.Add("USB", System.Drawing.Color.Red); // USB connection;
           viewport.Layers.Add("ETHERNET", System.Drawing.Color.Green); // Ethernet connection;
           viewport.Layers.Add("OTHER", System.Drawing.Color.Yellow); // Ethernet connection;
       }

       public static bool isCreateLayer = false;
       public static void DrawLine(ViewportLayout viewport, ConnectionInfor.ConnectionType connectType, Point3D startPoint, Point3D endPoint)
       {
           
           if (connectType == ConnectionInfor.ConnectionType.USB)
           {
               
               viewport.Entities.Add(new Bar(startPoint.X, startPoint.Y, startPoint.Z, endPoint.X, endPoint.Y, endPoint.Z, 1, 1), 1);
           }

           if (connectType == ConnectionInfor.ConnectionType.ETHER)
           {
               viewport.Entities.Add(new Bar(startPoint.X, startPoint.Y, startPoint.Z, endPoint.X, endPoint.Y, endPoint.Z, 1, 1), 2);
           }

           if (connectType == ConnectionInfor.ConnectionType.OTHER)
           {
               viewport.Entities.Add(new Bar(startPoint.X, startPoint.Y, startPoint.Z, endPoint.X, endPoint.Y, endPoint.Z, 1, 1), 3);
           }
       }

       const double offSet = 15;
       public static void DrawText(String content, Device oDevice, ViewportLayout viewport)
       {
           Text t4 = new Text(oDevice.OffsetX + offSet, oDevice.OffsetY, 0, content, 4);

           t4.Alignment = Text.alignmentType.MiddleCenter;

           viewport.Entities.Add(t4, 0, System.Drawing.Color.Blue);
       
       
       }
    }
}
