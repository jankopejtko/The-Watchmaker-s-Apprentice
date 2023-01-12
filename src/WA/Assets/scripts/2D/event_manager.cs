using UnityEngine.SceneManagement;
using UnityEngine;

public class event_manager : MonoBehaviour
{
    bool gameHasEnded = false; // prevent EndGame method to be executed forver

    [SerializeField] float restartDelay = 0f; // user of this script will set this value

    // method to invoke Restart method when game end -> event from event manager
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    // this method will restart the current scene
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
