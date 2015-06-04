using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porject3D
{
    public class ConnectionInfor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionInfo" /> class
        /// </summary>
        /// <param name="hop">Device which is connected to</param>
        /// <param name="connectType">Type of connection USB, Ethernet, Other</param>
        public ConnectionInfor(string hop, ConnectionType connectType)
        {
            this.Hop = hop;
            this.Type = connectType;
        }

        /// <summary>
        /// Gets or sets Connection Type
        /// </summary>
        public ConnectionType Type { get; set; }

        /// <summary>
        /// Gets or sets Connection Hop
        /// </summary>
        public string Hop { get; set; }

        /// <summary>
        /// Gets or sets Connection Type
        /// </summary>
        public enum ConnectionType
        {
            /// <summary>
            /// USB type
            /// </summary>
            USB,

            /// <summary>
            /// Ethernet Type
            /// </summary>
            ETHER,

            /// <summary>
            /// Other type
            /// </summary>
            OTHER
        }
    }
}
