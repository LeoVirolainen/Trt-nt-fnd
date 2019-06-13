
using UnityEngine;

public class SuCameraFollow : MonoBehaviour
{

     
    
     public Transform target;
     public float smoothSpeed = 0.125f;
     public Vector3 offset;

    

    private void LateUpdate()
     {
         Vector3 desiredPosition = target.position + offset;
         Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
         transform.position = smoothedPosition;

         transform.rotation = target.rotation;

         transform.LookAt(target);
    }
private void Update()
    {
        transform.rotation = Quaternion.Euler(0, target.rotation.y, 0);
    }
    /*
    
    float damp = 2.0f;

    private void Update()
    {
        var currentPos = transform.rotation * Vector3.forward * 10;

        var targetPos = Vector3.zero;
        if (target) targetPos = target.position;
        var rotation = transform.rotation;
        transform.LookAt(targetPos);

        var lookPos = transform.rotation * Vector3.forward * 10;

        transform.rotation = Quaternion.Lerp(rotation, transform.rotation, damp * Time.deltaTime);

        var actualPos = transform.rotation * Vector3.forward * 10;

        Debug.DrawLine(transform.position, transform.position + currentPos, Color.red);
        Debug.DrawLine(transform.position, transform.position + actualPos, Color.yellow);
        Debug.DrawLine(transform.position, transform.position + lookPos, Color.green);

        // currentPos is the initial rotation
        // actualPos is the rotation lerped
        // lookPos is the rotation based on where it wants to be
    }
    */


}
