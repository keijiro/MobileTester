using UnityEngine;

public class SystemInfoView : MonoBehaviour
{
    public GUIStyle labelStyle;

    void OnGUI()
    {
        var text = "";
        text += "Device Name: " + SystemInfo.deviceName + "\n";
        text += "Device Type: " + SystemInfo.deviceType + "\n";
        text += "Model Name: " + SystemInfo.deviceModel + "\n";
        text += "OS: " + SystemInfo.operatingSystem + "\n";
        text += "CPU: " + SystemInfo.processorType + " x " + SystemInfo.processorCount + "\n";
        text += "Memory: " + SystemInfo.systemMemorySize.ToString("#,0") + "kB (VRAM:" + SystemInfo.graphicsMemorySize.ToString("#,0") + "kB)\n";
        text += "GPU: " + SystemInfo.graphicsDeviceName + " (ID:" + SystemInfo.graphicsDeviceID + ")\n";
        text += "Vendor: " + SystemInfo.graphicsDeviceVendor + " (ID:" + SystemInfo.graphicsDeviceVendorID + ")\n";
        text += "Driver: " + SystemInfo.graphicsDeviceVersion + " (SM:" + SystemInfo.graphicsShaderLevel + ")\n";
        text += "Resolution: " + Screen.width + " x " + Screen.height + "\n";
        text += "UDID: " + SystemInfo.deviceUniqueIdentifier;
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height), text, labelStyle);
    }
}
