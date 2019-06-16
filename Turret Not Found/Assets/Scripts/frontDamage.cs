using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontDamage : MonoBehaviour {
    public BoxCollider frontCol;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "projectile") {
            print("lose 1 armour!");
            GetComponent<TankController>().armour -= 1f;
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        if (GetComponent<TankController>().armour <= 0f) {
            Tankdie();
        }
    }

    private void Tankdie() {
        GetComponent<TankController>().speed = 0f;
        GetComponent<TankController>().turningSpeed = 0f;
        GetComponentInChildren<tankShooting>().enabled = false;
        print((gameObject.name) + " destroyed!");
    }

}
