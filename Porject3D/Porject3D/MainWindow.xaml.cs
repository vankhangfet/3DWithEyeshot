using devDept.Eyeshot.Translators;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Porject3D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// The Threshold for calculating the distance between each device
        /// </summary>
        private const double THRESH = 50;

        public MainWindow()
        {
            InitializeComponent();
            Utility3D.CreateLayout(viewport);
            viewport.DisplayMode = devDept.Eyeshot.displayType.Shaded;
            InitialDevice();
        }

        private void bntLoad_Click(object sender, RoutedEventArgs e)
        {

            //Demo();
           InitialDevice();
        }

        public void Demo()
        {
            string file = @"Model\fx-501.IGS";
            ReadIGES objIEGS = new ReadIGES(file);
            objIEGS.DoWork();
            objIEGS.AddToScene(viewport);

            Utility3D.Scale(objIEGS, 1.0);

            Utility3D.Rotate(objIEGS, 180.0, new devDept.Geometry.Vector3D(0.0, 0.0, 0.0));

            string file1 = @"Model\lp-s500wc.IGS";
            ReadIGES objIEGS1 = new ReadIGES(file1);
            objIEGS1.DoWork();
            objIEGS1.AddToScene(viewport);

            Utility3D.Scale(objIEGS1, 0.1);
            Utility3D.Rotate(objIEGS1, 180.0, new devDept.Geometry.Vector3D(0.0, 0.0, 0.0));
            Utility3D.Transalte(objIEGS1, 50.0, 0.0, 0.0);
           
            viewport.Invalidate();
            // Draw line 
            var startPoint = new Point3D(0.0, 0.0, 0.0);
            var endPoint = new Point3D(50.0, 0.0, 0.0);
            Utility3D.DrawLine(viewport, ConnectionInfor.ConnectionType.USB, startPoint, endPoint);
        
        }

        List<Device> oListDevice = new List<Device>();
       // List<ReadFileAsynch> oListData = new List<ReadFileAsynch>();
        public void InitialDevice()
        {

            oListDevice = this.createListDevice();
            this.displayNetWork3D(oListDevice);
            foreach (var item in oListDevice)
            {
                LoadData(item);
            }
            

            // Correct position devices 
            foreach (var device in oListDevice)
            {
                if ((device.OffsetX != 0.0) || (device.OffsetY != 0.0) || (device.OffsetZ!=0.0))
                {  
                    if(!device.FileModel.Contains(".stl"))
                    { 
                        Utility3D.Transalte(device.ModelData, device.OffsetX, device.OffsetY, device.OffsetZ);
                    }
                }
            }
            //
            foreach (var device in oListDevice)
            {
                if(!device.FileModel.Contains(".stl"))
                { 
                    viewport.StartWork(device.ModelData);
                }
                Utility3D.DrawText(device.DeviceName, device, viewport);
            }

            // Connect device 
            this.ConnectDevice(oListDevice);
            // Draw text 
            
        }


        private List<Device> createListDevice()
        {
            List<Device> listDevice;
            listDevice = new List<Device>();

            ConnectionInfor connection = new ConnectionInfor("PC000", ConnectionInfor.ConnectionType.USB);
            Device device = new Device(@"Model\fx-501.IGS", "fx-501", "FX001", connection);
            device.Scale = 0.5;
            device.AngleRadian = 180.0;
            listDevice.Add(device);

            connection = new ConnectionInfor("PC000", ConnectionInfor.ConnectionType.ETHER);
            device = new Device(@"Model\lp-s500wc.IGS", "SC-GU-485", "SCGU01", connection);
            device.Scale = 0.05;
            device.AngleRadian = 180.0;
            listDevice.Add(device);

            connection = new ConnectionInfor("HLC002", ConnectionInfor.ConnectionType.OTHER);
            device = new Device(@"Model\lp-s500wc.IGS", "PC", "PC000", connection);
            device.Scale = 0.05;
            device.AngleRadian = 180.0;
            listDevice.Add(device);

            connection = new ConnectionInfor("FX001", ConnectionInfor.ConnectionType.USB);
            device = new Device(@"Model\aig03mq03de.IGS", "HL-G103", "HLC001", connection);
            device.Scale = 0.25;
            device.AngleRadian = 0.0;
            listDevice.Add(device);

            connection = new ConnectionInfor("PC000", ConnectionInfor.ConnectionType.ETHER);
            device = new Device(@"Model\PC.stl", "STL_OBJ", "STL_OBJ1", connection);
            device.Scale = 0.25;
            device.AngleRadian = 0.0;
            listDevice.Add(device);

            return listDevice;
        }

        private void LoadData( Device item)
        {  
            int index = 0;
            string fileName = item.FileModel;
            if (fileName.Contains(".obj"))
            {
                index = 3;
            }
           else if (fileName.Contains(".stl"))
            {
                index = 2;
            }
           else if (fileName.Contains(".IGS"))
            {
                index = 4;
            }

            switch (index)
            {
                case 1:
                    {
                        ReadASC objASC = new ReadASC(fileName);
                        objASC.DoWork();
                        objASC.AddToScene(viewport);
                        item.ModelData = objASC;
                        Utility3D.Scale(item.ModelData, item.Scale);
                        Utility3D.Rotate(item.ModelData, item.AngleRadian, new devDept.Geometry.Vector3D(0.0, 0.0, 0.0));
                    }
                    break;

                case 2:
                    {
                        ReadSTL objSTL = new ReadSTL(fileName);
                        objSTL.DoWork();
                        //item.ModelData = objSTL;
                        Utility3D.Scale(objSTL, item.Scale);
                        Utility3D.Rotate(objSTL, item.AngleRadian, new devDept.Geometry.Vector3D(0.0, 0.0, 0.0));
                        Utility3D.Transalte(objSTL, item.OffsetX, item.OffsetY, item.OffsetZ);
                        objSTL.AddToScene(viewport);
                       // oListData.Add(objSTL);
                       
                        
                    }
                    break;

                case 3:
                    {
                        ReadOBJ objOBJ = new ReadOBJ(fileName);
                        objOBJ.DoWork();
                        objOBJ.AddToScene(viewport);
                        //oListData.Add(objOBJ);
                        item.ModelData = objOBJ;
                        Utility3D.Scale(item.ModelData, item.Scale);
                        Utility3D.Rotate(item.ModelData, item.AngleRadian, new devDept.Geometry.Vector3D(0.0, 0.0, 0.0));
                    }
                    break;
                case 4:
                    {
                        ReadIGES objIEGS = new ReadIGES(fileName);
                        objIEGS.DoWork();
                        objIEGS.AddToScene(viewport);
                        //oListData.Add(objIEGS);
                        item.ModelData = objIEGS;
                        Utility3D.Scale(item.ModelData, item.Scale);
                        Utility3D.Rotate(item.ModelData, item.AngleRadian, new devDept.Geometry.Vector3D(0.0, 0.0, 0.0));
                    }
                    break;

                case 5:
                    {
                        ReadSTEP objSTEP = new ReadSTEP(fileName);
                        objSTEP.DoWork();
                        objSTEP.AddToScene(viewport);
                        //oListData.Add(objSTEP);
                        item.ModelData = objSTEP;
                        Utility3D.Scale(item.ModelData, item.Scale);
                        Utility3D.Rotate(item.ModelData, item.AngleRadian, new devDept.Geometry.Vector3D(0.0, 0.0, 0.0));
                    }
                    break;

            }

        }

        /// <summary>
        /// Draw the network 3D
        /// </summary>
        /// <param name="listDevice">
        /// List of device 
        /// </param>
        public void displayNetWork3D(List<Device> listDevice)
        {
            double offsetX = 0;
            double offsetY = 0;
            double offsetZ = 0;
            double halfNum = 0;

            // Divide the number of device in a half
            if (listDevice.Count > 1)
            {
                halfNum = listDevice.Count / 2;
            }
            else
            {
                halfNum = 1;
            }

            int idx = 0;
            double delta = THRESH / halfNum;
            double k = 10;
            ////Distribute the list device in the 4 areas around the center of the screen
            // /// The larger number of devices, the smaller distance between each devices
            foreach (Device device in listDevice)
            {
                idx++;
                if (idx % 4 == 0)
                {
                    offsetX = idx *k + delta;
                    offsetY = idx *k - delta;
                }
                else if (idx % 4 == 1)
                {
                    offsetX = idx *k + delta;
                    offsetY = -(idx *k - delta);
                }
                else if (idx % 4 == 2)
                {
                    offsetX = -(idx *k + delta);
                    offsetY = -(idx *k - delta);
                }
                else if (idx % 4 == 3)
                {
                    offsetX = -(idx *k + delta);
                    offsetY = idx *k - delta;
                }

                ////Draw label at each device, and scale size of device
                if (device.DeviceName != "PC")
                {
                    device.OffsetX = offsetX;
                    device.OffsetY = offsetY;
                    device.OffsetZ = offsetZ;
                }
                else
                {
                    ////Draw the PC device at the center of screeen
                    device.OffsetX = 0.0;
                    device.OffsetY = 0.0;
                    device.OffsetZ = 0.0;

                }
                ////Draw line to connect each device
               // this.ConnectDevice(listDevice);
            }
        }

        /// <summary>
        /// Check the connectionHop is exist in the list device
        /// </summary>
        /// <param name="listDevice"> List of devices </param>
        /// <param name="connectionHop">Connection type</param>
        /// <returns>
        /// - 1: Not found
        /// Index of device in list
        /// </returns>
        private int GetDeviceIndex(List<Device> listDevice, string connectionHop)
        {
            int index = 0;
            bool isFound = false;
            foreach (Device device in listDevice)
            {
                if (connectionHop == device.DeviceId)
                {
                    isFound = true;
                    break;
                }

                index++;
            }

            if (!isFound)
            {
                index = -1;
            }

            return index;
        }

        private void ConnectDevice(List<Device> listDevice)
        {
            foreach (Device device in listDevice)
            {
                int index = this.GetDeviceIndex(listDevice, device.ConnectType.Hop);
                if (index != -1)
                {
                    

                    var postX = device.OffsetX ;
                    var postY = device.OffsetY ;
                    var postZ = device.OffsetZ ;

                    Point3D startPoint = new Point3D(postX, postY, postZ);
                   
                    var postEndX = listDevice[index].OffsetX ;
                    var postEndY = listDevice[index].OffsetY ;
                    var postEndZ = listDevice[index].OffsetZ ;

                    Point3D endPoint = new Point3D(postEndX , postEndY , postEndZ );
                    Utility3D.DrawLine(viewport, device.ConnectType.Type, startPoint, endPoint);
                }

            }
        }

    }
}
