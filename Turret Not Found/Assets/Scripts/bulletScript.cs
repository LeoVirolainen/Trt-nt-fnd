using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

    private void OnTriggerEnter(Collider Other) {
        Destroy(gameObject);
    }

}
