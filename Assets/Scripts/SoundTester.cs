using UnityEngine;
using System.Collections;

public class SoundTester : MonoBehaviour
{
    void Update ()
    {
        foreach (var touch in Input.touches) {
            if (touch.phase == TouchPhase.Began) {
                audio.Play();
                break;
            }
        }
    }
}