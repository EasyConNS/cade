using System.Management;

namespace Usb
{
    public interface IUsbDevice
    {
        ManagementBaseObject WmiDevice { get; }

        ushort VendorId { get; }

        ushort ProductId { get; }

        ushort RevisionBcd { get; }

        string ManufacturerString { get; }

        string ProductString { get; }

        string Driver { get; }
    }
}
