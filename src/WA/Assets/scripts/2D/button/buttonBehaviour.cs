using UnityEngine.SceneManagement;
using UnityEngine;

public class buttonBehaviour : MonoBehaviour
{
    public static void loadScene(string sceneName) //load scene based on its name
    {
        SceneManager.LoadScene(sceneName);
    }
    public static void leaveGame() //exit the game
    {
        Application.Quit();
    }
    public static void playGame() //load scene based on progress
    {
        //todo chack if player play the game for the first time
    }
    public static void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public static void hideQuickMenu(GameObject go) 
    {
        quickMenu.isVisible = true;
        Time.timeScale = 1;
        go.SetActive(false);
    } 
}
//todo comment code