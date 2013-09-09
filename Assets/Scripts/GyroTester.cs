using UnityEngine;
using System.Collections;

public class GyroTester : MonoBehaviour
{
    void Start ()
    {
        Input.gyro.enabled = true;
    }

    void Update ()
    {
        ShowHideAxes (Input.gyro.enabled);

        if (Input.gyro.enabled) {
            Quaternion q = Input.gyro.attitude;
            q.z *= -1.0f;
            transform.localRotation = q;
        }
    }

    void ShowHideAxes (bool flag)
    {
        foreach (var r in GetComponentsInChildren<Renderer>()) {
            if (r.gameObject.name == "Axis") {
                r.enabled = flag;
            }
        }
    }
}