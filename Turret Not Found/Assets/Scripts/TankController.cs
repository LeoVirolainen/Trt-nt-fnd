using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public float turningSpeed;

    public KeyCode forward;
    public KeyCode reverse;
    public KeyCode left;
    public KeyCode right;


    void Update() {

        if (Input.GetKey(forward)) {
            rb.MovePosition(rb.position + rb.transform.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(reverse)) {
            rb.MovePosition(rb.position - rb.transform.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(left)) {
            var dr = Quaternion.Euler(0, -turningSpeed * Time.deltaTime, 0);
            rb.MoveRotation(rb.rotation * dr);
        }
        if (Input.GetKey(right)) {
            var dr = Quaternion.Euler(0, turningSpeed * Time.deltaTime, 0);
            rb.MoveRotation(rb.rotation * dr);
        }
    }
}
