using Nop.Core.Domain.Common;

namespace Nop.Services.Common
{
    /// <summary>
    /// Device service interface
    /// </summary>
    public partial interface IDeviceService
    {
        /// <summary>
        /// Inserts/Update an device
        /// </summary>
        /// <param name="device">Device</param>
        void InsertUpdateDevice(Device device);

    }
}