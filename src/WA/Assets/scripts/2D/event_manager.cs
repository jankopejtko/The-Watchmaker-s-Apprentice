using UnityEngine.SceneManagement;
using UnityEngine;

public class event_manager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 0f;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
