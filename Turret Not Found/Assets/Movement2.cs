using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public float turningSpeed;


    void Update() {

        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.MovePosition(rb.position + rb.transform.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            rb.MovePosition(rb.position - rb.transform.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            var dr = Quaternion.Euler(0, -turningSpeed * Time.deltaTime, 0);
            rb.MoveRotation(rb.rotation * dr);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            var dr = Quaternion.Euler(0, turningSpeed * Time.deltaTime, 0);
            rb.MoveRotation(rb.rotation * dr);
        }
    }
}