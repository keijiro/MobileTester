#pragma strict

var skin : GUISkin;
private var acc : Vector3;
private var filter : boolean;

function Update() {
    if (filter) {
        acc = Vector3.Lerp(acc, Input.acceleration, 0.2);
    } else {
        acc = Input.acceleration;
    }
    var grav = Vector3(-acc.y, acc.x, -acc.z);
    transform.localRotation = Quaternion.FromToRotation(Vector3.forward, grav);
}

function OnGUI() {
    GUI.skin = skin;

    GUILayout.BeginArea(Rect(0, 0, Screen.width, Screen.height));

    if (GUILayout.Button("Filter: " + (filter ? "enabled" : "disabled"))) {
        filter ^= true;
    }

    GUILayout.Label("X: " + acc.x.ToString("F2"));
    GUILayout.Label("Y: " + acc.y.ToString("F2"));
    GUILayout.Label("Z: " + acc.z.ToString("F2"));

    GUILayout.EndArea();
}
