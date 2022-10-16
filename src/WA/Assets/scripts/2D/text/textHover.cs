//Jan Kopejtko, 2022

using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class textHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //SerializeField will protect the private variable but they will be still visible in editor
    [SerializeField] private List<Text> textList; //GUI text from menu bar that will change color on hover
    [SerializeField] private GameObject marker; //Game object that indicates selected button (only for menu text)
    public Color baseColor; //from editor select color of text that is not hovered
    public Color hoverColor; //from editor select color of text that is hovered

    public void OnPointerEnter(PointerEventData eventData) //script will execute when cursor hover the object that this script is attached on
    {
        for (int index = 0; index < textList.Count; index++)// loop all object in array (textList)
        {
            textList[index].color = hoverColor; //set color of the text to white
        }
        try //if marker is null  return
        {
            marker.SetActive(true); //set visual marker as active (visible)
        }
        catch 
        {
            return;
        }
    }
    public void OnPointerExit(PointerEventData eventData) //script will execute when cursor exit the object that this script is attached on
    {
        for (int index = 0; index < textList.Count; index++)// loop all object in array (textList)
        {
            textList[index].color = baseColor; //set color of the text to white
        }
        try //if marker is null then return
        {
            marker.SetActive(false); //set visual marker as inactive (unvisible)
        }
        catch
        {
            return;
        }
    }
}