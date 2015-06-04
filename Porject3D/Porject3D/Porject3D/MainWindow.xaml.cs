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
        public MainWindow()
        {
            InitializeComponent();
            Utility3D.CreateLayout(viewport);
            string file = @"Model\PC.stl";
            ReadSTL objIEGS = new ReadSTL(file);
            objIEGS.DoWork();
            Utility3D.Sacle(objIEGS, 0.5);
            Utility3D.Rotate(objIEGS, 0.0, new devDept.Geometry.Vector3D(0.0, 0.0, 0.0));
            objIEGS.AddToScene(viewport);

            string file1 = @"Model\Server.stl";
            ReadSTL objIEGS1 = new ReadSTL(file1);
            objIEGS1.DoWork();
            Utility3D.Sacle(objIEGS1, 0.5);
            Utility3D.Rotate(objIEGS1, 90.0, new devDept.Geometry.Vector3D(0.0, 0.0, 0.0));
            Utility3D.Transalte(objIEGS1, 60.0, 0.0, 0.0);
            objIEGS1.AddToScene(viewport);
            viewport.Invalidate();
           
        }

       
    }
}
