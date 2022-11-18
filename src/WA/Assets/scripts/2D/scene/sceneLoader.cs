using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
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

}
