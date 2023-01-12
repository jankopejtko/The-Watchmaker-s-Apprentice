//Jan Kopejtko, 2022

using UnityEngine.SceneManagement;
using UnityEngine;

public class teleportToLevel : MonoBehaviour
{
    [SerializeField] private activation activation;
    [SerializeField] private string levelName;
    void Update()
    {
        if(activation.active == true) 
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
//todo comment code