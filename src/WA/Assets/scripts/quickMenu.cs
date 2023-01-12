using UnityEngine;

public class quickMenu : MonoBehaviour
{
    [SerializeField] GameObject menu;
    public static bool isVisible = true;
    private void Start()
    {
        Time.timeScale = 1;
        isVisible = true;
    }
    void Update()
    {
        CursorScript.setVisibility(false);
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            menu.SetActive(isVisible);
            isVisible = !isVisible;
        }
        if (!isVisible)
        {
            Time.timeScale = 0;
        }
        else Time.timeScale = 1;
    }
}
//todo comment code