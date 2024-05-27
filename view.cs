using UnityEngine;

public class MouseRotateCamera : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        // Get the horizontal mouse movement input
        float mouseX = Input.GetAxis("Mouse X");

        // Rotate the camera based on horizontal mouse movement
        RotateCamera(mouseX);
    }

    void RotateCamera(float mouseX)
    {
        // Calculate the rotation angle based on horizontal mouse movement
        float rotationY = transform.rotation.eulerAngles.y + mouseX * rotationSpeed;

        // Set the new rotation angles
        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
    }
}
