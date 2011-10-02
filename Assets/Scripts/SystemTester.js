#pragma strict

var skin : GUISkin;

function OnGUI() {
    GUI.skin = skin;

    GUILayout.BeginArea(Rect(0, 0, Screen.width, Screen.height));
    GUILayout.FlexibleSpace();
    GUILayout.Label(
        "OS: " + SystemInfo.operatingSystem +
        "\nCPU: " + SystemInfo.processorType + " x " + SystemInfo.processorCount +
        "\nSysMem: " + SystemInfo.systemMemorySize + " VRAM: " + SystemInfo.graphicsMemorySize +
        "\nGPU: " + SystemInfo.graphicsDeviceName + " " + SystemInfo.graphicsDeviceVendor +
        "\nShaderLv: " + SystemInfo.graphicsShaderLevel + " Fill: " + SystemInfo.graphicsPixelFillrate +
        "\nUDID: " + SystemInfo.deviceUniqueIdentifier +
        "\nDevice: " + SystemInfo.deviceName + " " + SystemInfo.deviceModel
    );
    GUILayout.EndArea();
}
