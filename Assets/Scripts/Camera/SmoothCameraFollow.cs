using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Offset from the player
    public float smoothSpeed = 0.125f; // Speed of the smooth follow

    private Vector3 initialCameraRotation;

    void Start()
    {
        // Store the initial rotation of the camera
        initialCameraRotation = transform.rotation.eulerAngles;
    }

    void LateUpdate()
    {
        // Desired position based on player's position and offset
        Vector3 desiredPosition = player.position + offset;
        // Smoothly interpolate between current position and desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Set the camera's position to the smoothed position
        transform.position = smoothedPosition;

        // Maintain the original rotation of the camera
        transform.rotation = Quaternion.Euler(initialCameraRotation);
    }
}