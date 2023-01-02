using UnityEngine;
using UnityEngine.UI;

public class showCanvas : MonoBehaviour
{
    [SerializeField] private activation activation;
    [SerializeField] private Canvas canvas;
    void Update()
    {
        if (activation.active == true) 
        {
            showDialog();
        }
        else 
        {
            hideDialog();
        }
    }
    void showDialog() 
    {
        canvas.enabled = true;
    }
    void hideDialog() 
    {
        canvas.enabled = false;
    }
}
