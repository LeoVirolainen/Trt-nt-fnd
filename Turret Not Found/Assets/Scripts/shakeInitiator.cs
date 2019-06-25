using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeInitiator : MonoBehaviour
{

    public screenShaker Shaker;
    public float duration = 1f;

    public KeyCode shakeKey;

    private void Update() {
        if (Input.GetKeyDown(shakeKey)) {
            Shaker.Shake(duration);
        }
    }
}
