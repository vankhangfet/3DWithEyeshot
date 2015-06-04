using devDept.Eyeshot.Translators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porject3D
{
   public class Device
    {
        public Device()
        {


        }

        /// <summary>
        ///  Initializes a new instance of the <see cref="Device" /> class
        /// </summary>
        /// <param name="fileModel">Name of File Model</param>
        /// <param name="deviceName">Name Of Device</param>
        /// <param name="deviceId">Device ID</param>
        /// <param name="connect">Connection Type</param>
        public Device(string fileModel, string deviceName, string deviceId, ConnectionInfor connect)
        {
            this.FileModel = fileModel;
            this.DeviceName = deviceName;
            this.DeviceId = deviceId;
            this.ConnectType = connect;
            this.Scale = 1.0;
        }

        /// <summary>
        /// Gets or sets Name of Model File 
        /// </summary>
        public string FileModel { get; set; }

        /// <summary>
        /// Gets or sets Device Name
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Gets or sets Device Id
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets OffsetX
        /// </summary>
        public double OffsetX { get; set; }

        /// <summary>
        /// Gets or sets OffsetY
        /// </summary>
        public double OffsetY { get; set; }

        /// <summary>
        /// Gets or sets OffsetZ
        /// </summary>
        public double OffsetZ { get; set; }

        /// <summary>
        /// Get or sets Scale
        /// </summary>
        public double Scale { get; set; }

        /// <summary>
        /// Get or sets AngleRadian
        /// </summary>
        public double AngleRadian { get; set; }

        /// <summary>
        /// Gets or sets Connection Type
        /// </summary>
        public ConnectionInfor ConnectType { get; set; }

        public ReadFileAsynch ModelData { get; set; }
    }
}
