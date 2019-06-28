using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public float turningSpeed;
    public float armour = 3f;

    public KeyCode forward;
    public KeyCode reverse;
    public KeyCode left;
    public KeyCode right;
    public KeyCode fireKey;

    public Animator TankAnimr;


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

        if (Input.GetKeyDown(fireKey)) {
            speed = speed / 2;
            turningSpeed = turningSpeed / 2;
        }
        if (Input.GetKeyUp(fireKey)) {
            speed = speed * 2;
            turningSpeed = turningSpeed * 2;
        }
       
        //ANIMATION TRIGGERS

        if (Input.GetKeyDown(forward)) {
            TankAnimr.Play("MoveStart");
        }
        if (Input.GetKeyUp(forward)) {
            TankAnimr.Play("MoveStop");
        }
        if (Input.GetKeyDown(reverse)) {
            TankAnimr.Play("MoveStop");
        }
        if (Input.GetKeyUp(reverse)) {
            TankAnimr.Play("MoveStart");
        }
    }
}
