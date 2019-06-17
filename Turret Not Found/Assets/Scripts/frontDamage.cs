using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontDamage : MonoBehaviour {
    public float dmgOnPene;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "projectile") {
            print("Penetration!");
            GetComponent<TankController>().armour -= dmgOnPene;
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        if (GetComponent<TankController>().armour <= 0f) {
            Tankdie();
        }
    }

    public void Tankdie() {
        GetComponent<TankController>().speed = 0f;
        GetComponent<TankController>().turningSpeed = 0f;
        GetComponentInChildren<tankShooting>().enabled = false;
        print((gameObject.name) + " destroyed!");
    }

}
