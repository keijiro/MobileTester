#pragma strict

var texture : Texture2D;

function OnGUI() {
    var size = Screen.width / 2;
    for (var touch in Input.touches) {
        var rect = Rect(touch.position.x - size / 2, Screen.height - touch.position.y - size / 2, size, size);
        GUI.DrawTexture(rect, texture);
    }
}
