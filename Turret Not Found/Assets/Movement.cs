using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public float turningSpeed;


    void Update()
    {

        if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(rb.position + rb.transform.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(rb.position - rb.transform.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            var dr = Quaternion.Euler(0, -turningSpeed * Time.deltaTime, 0);
            rb.MoveRotation(rb.rotation * dr);
        }
        if (Input.GetKey(KeyCode.D))
        {
            var dr = Quaternion.Euler(0, turningSpeed * Time.deltaTime, 0);
            rb.MoveRotation(rb.rotation * dr);
        }
    }
}
