
using UnityEngine;

public class EndReached : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().name == "Player")
        {
            Debug.Log("Geldiiimmm");
            gameManager.CompleteLevel();
        }
    }
}

