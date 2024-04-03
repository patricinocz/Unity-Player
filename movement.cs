using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
