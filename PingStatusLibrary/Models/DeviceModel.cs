using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingStatusLibrary.Models
{
    public class DeviceModel
    {
        /// <summary>
        /// The unique ID for the device
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Device description. For example, Lab Computer,  
        /// </summary>
        public string DeviceDescription { get; set; }

        /// <summary>
        /// Enables status check (ping) for device
        /// </summary>
        public bool EnableCheck { get; set; }

        /// <summary>
        /// The name or IP address for the device
        /// </summary>
        public string DeviceNameAddress { get; set; }
    }
}
