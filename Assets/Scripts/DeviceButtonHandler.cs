using UnityEngine;
using System.Collections;

public class DeviceButtonHandler : MonoBehaviour
{
    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.Escape)) {
            Application.Quit ();
        }
    }
}