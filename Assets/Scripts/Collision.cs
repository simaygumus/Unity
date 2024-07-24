using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    public PlayerMovement movement;
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide");
        if (collision.collider.tag == "Wall")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
