//Jan Kopejtko 2022

using UnityEngine.SceneManagement; //<--- scene manipulation
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class events : MonoBehaviour
{
    void backToMenu() //this function will be called from animation event
    {
        SceneManager.LoadScene("menu"); //load game menu
    }
}