using System.ComponentModel;

namespace HomeAutomation.Models.Enums
{
    public enum ConnectionEnum
    {
        [Description("None")]
        None = 0,
        [Description("Wi-Fi")]
        WiFi,
        [Description("Bluetooth BLE")]
        BLE,
        [Description("ZigBee")]
        ZigBee,
        [Description("Z-Wave")]
        ZWave
    }
}
