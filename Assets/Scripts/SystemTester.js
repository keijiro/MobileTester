#pragma strict

var skin : GUISkin;

function OnGUI() {
    GUI.skin = skin;

    GUILayout.BeginArea(Rect(0, 0, Screen.width, Screen.height));
    GUILayout.FlexibleSpace();
    GUILayout.Label(
        "OS: " + SystemInfo.operatingSystem +
        "\nCPU: " + SystemInfo.processorType + " x " + SystemInfo.processorCount +
        "\nMemory: " + SystemInfo.systemMemorySize + " VRAM: " + SystemInfo.graphicsMemorySize +
        "\nGPU: " + SystemInfo.graphicsDeviceName + " (ID:" + SystemInfo.graphicsDeviceID + ")" +
        "\nVendor: " + SystemInfo.graphicsDeviceVendor + " (ID:" + SystemInfo.graphicsDeviceVendorID + ")" +
        "\nAPI: " + SystemInfo.graphicsDeviceVersion + " Shader: " + SystemInfo.graphicsShaderLevel + " Fillrate: " + SystemInfo.graphicsPixelFillrate +
        "\nUDID: " + SystemInfo.deviceUniqueIdentifier +
        "\nDevice Name: " + SystemInfo.deviceName + " Model:" + SystemInfo.deviceModel
    );
    GUILayout.EndArea();
}
