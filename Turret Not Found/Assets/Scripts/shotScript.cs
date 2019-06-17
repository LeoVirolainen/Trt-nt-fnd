using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotScript : MonoBehaviour {
    public float timer = 0f;
    public float timelimit = 2f;

    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
    }

    private void Update() {
        timer += 1f * Time.deltaTime;
        if (timer >= timelimit) {
            Destroy(gameObject);
        }
    }
}
