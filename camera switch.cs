using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;

    void Start()
    {
        // Ensure one of the cameras is initially enabled
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
    }

    void Update()
    {
        // Check for the "C" key press
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Toggle camera states
            ToggleCameras();
        }
    }

    void ToggleCameras()
    {
        // Toggle the enabled state of the cameras
        firstPersonCamera.enabled = !firstPersonCamera.enabled;
        thirdPersonCamera.enabled = !thirdPersonCamera.enabled;
    }
}
