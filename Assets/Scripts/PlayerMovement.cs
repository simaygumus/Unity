using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Amount to move the object each time a key is pressed
    public float moveDistance = 1.0f;
    public float minXPosition = -1.0f;
    public float maxXPosition = 1.0f;


    void Update()
    {
        // Check if the 'A' key is pressed
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > minXPosition)
        {
            // Move the object to the left
            transform.position += Vector3.left * moveDistance;
        }

        // Check if the 'D' key is pressed
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x <maxXPosition)
        {
            // Move the object to the right
            transform.position += Vector3.right * moveDistance;
        }
    }
}
