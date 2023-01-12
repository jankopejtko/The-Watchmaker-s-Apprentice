//Jan Kopejtko, 2022

using UnityEngine.SceneManagement;
using UnityEngine;
public class loadSceneByKey : MonoBehaviour
{
    [SerializeField] KeyCode key;
    [SerializeField] string scene;

    void backToMenu(KeyCode key, string scene)
    {
        if (Input.GetKeyDown(key)) //checks if user pressed key
        {
            SceneManager.LoadScene(scene); //load to scene
        }
    }
    private void Update()
    {
        //check every frame
        backToMenu(key,scene);
    }
}