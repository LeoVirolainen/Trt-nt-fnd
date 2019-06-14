
using UnityEngine;

public class SuCameraFollow : MonoBehaviour
{

    public Transform seat;
    public Transform target;
    public float smoothSpeed = 0.125f;
    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
     {
         Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, seat.position, ref velocity, smoothSpeed);
         transform.position = smoothedPosition;

         transform.rotation = seat.rotation;

         transform.LookAt(target);
    }
}
