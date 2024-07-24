using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float startingDelay = 3f;
    public GameObject completeLevelUI;
    public void EndGame()
    {
        if (!gameEnded)
        {
            Debug.Log("Game Over");
            gameEnded = true;
            Invoke("Restart", startingDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Won!!");
        completeLevelUI.SetActive(true);
    }
}
