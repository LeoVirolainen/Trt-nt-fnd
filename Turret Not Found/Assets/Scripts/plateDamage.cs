using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateDamage : MonoBehaviour {
    public BoxCollider sideCol;
    public float dmgOnPene;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "projectile") {
            print("Hit skirts! -1.5 AP");
            GetComponentInParent<TankController>().armour -= dmgOnPene;
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        if (GetComponentInParent<TankController>().armour <= 0f) {
            GetComponentInParent<frontDamage>().Tankdie();
        }
    }
}
