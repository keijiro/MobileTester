using UnityEngine;
using System.Collections;

public class SystemInfoView : MonoBehaviour
{
    public GUISkin skin;

    void OnGUI ()
    {
        GUI.skin = skin;
        GUILayout.BeginArea (new Rect (0, 0, Screen.width, Screen.height));
        GUILayout.FlexibleSpace ();
        GUILayout.Label (
            "OS: " + SystemInfo.operatingSystem +
            "\nCPU: " + SystemInfo.processorType + " x " + SystemInfo.processorCount +
            "\nMemory: " + SystemInfo.systemMemorySize + " VRAM: " + SystemInfo.graphicsMemorySize +
            "\nGPU: " + SystemInfo.graphicsDeviceName + " (ID:" + SystemInfo.graphicsDeviceID + ")" + " Vendor: " + SystemInfo.graphicsDeviceVendor + " (ID:" + SystemInfo.graphicsDeviceVendorID + ")" +
            "\nDriver: " + SystemInfo.graphicsDeviceVersion + " SM: " + SystemInfo.graphicsShaderLevel + " Fillrate: " + SystemInfo.graphicsPixelFillrate +
            "\nUDID: " + SystemInfo.deviceUniqueIdentifier +
            "\nDevice Name: " + SystemInfo.deviceName + " Model:" + SystemInfo.deviceModel + " Type:" + SystemInfo.deviceType
        );
        GUILayout.EndArea ();
    }
}
