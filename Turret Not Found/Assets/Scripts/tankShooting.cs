using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankShooting : MonoBehaviour {
    public Transform output;
    public Rigidbody shell;

    public float launchForce;
    public float reloadTime = 3f;

    private bool isReloading = false;
    private bool fired = true;

    public KeyCode fireKey;

    void Update() {

        if (isReloading) {
            return;
        }
        else if (!fired) {
            Shoot();
        }
        else if (Input.GetKeyDown(fireKey)) {
            fired = false;
        }
    }

    private void Shoot() {
        fired = true;
        Rigidbody shellInstance = Instantiate(shell, output.position, output.rotation) as Rigidbody;
        shellInstance.velocity = launchForce * output.forward;
        StartCoroutine(Reload());
    }

    IEnumerator Reload() {
        isReloading = true;
        print("reloading...");
        yield return new WaitForSeconds(reloadTime);
        isReloading = false;
        print("loaded!");
    }
}
