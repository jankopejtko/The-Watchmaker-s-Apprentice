using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showNPCDialog : MonoBehaviour
{
    [SerializeField] private activation activation;
    [SerializeField] private Canvas canvas;
    public Text dialog;
    private int levelsLeft = 5;
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
        //todo get non complete levels num
        canvas.enabled = true;
        dialog.text = "Zbývá ti ještì nasbírat " + levelsLeft + " ozubených koleèek";
    }
    void hideDialog() 
    {
        canvas.enabled = false;
        dialog.text = "";
    }
}
