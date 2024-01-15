using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f; 

    void LateUpdate()
    {
        if (target != null)
        {
            float desiredX = target.position.x;
            Vector3 desiredPosition = new Vector3(desiredX, transform.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
