using UnityEngine;
using System.Collections;

public class TouchTester : MonoBehaviour
{
    public Texture2D texture;

    void Update ()
    {
        if (Input.touches.Length > 0) {
            transform.localScale = Vector3.one * 2.0f;
        } else {
            transform.localScale = Vector3.one;
        }
    }
    
    void OnGUI ()
    {
        var size = Screen.width / 2;
        foreach (var touch in Input.touches) {
            GUI.DrawTexture (new Rect (touch.position.x - size / 2, Screen.height - touch.position.y - size / 2, size, size), texture);
        }
    }
}