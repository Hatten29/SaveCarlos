using UnityEngine;

public class Cignet : MonoBehaviour
{
    public Transform target; // The target to follow (the camera in this case)
    public float fixedYPosition = 2f; // The fixed y-position for the object
    public float smoothSpeed = 5f; // The smoothing factor for movement

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired x and z position based on the camera's position
            float desiredX = target.position.x;
            float desiredZ = target.position.z;

            // Interpolate the current position to the desired position with smoothing
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, new Vector3(desiredX, fixedYPosition, desiredZ), smoothSpeed * Time.deltaTime);

            // Set the position of the object
            transform.position = smoothedPosition;

            // Make the object look at the camera
            transform.LookAt(target.position);
        }
    }
}
