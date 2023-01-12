using UnityEngine;

public class CursorScript : MonoBehaviour
{
    [SerializeField] bool visible;
    //Start for initialization
    void Start()
    {
        //Set Cursor visibility
        Cursor.visible = visible;
    }
    //This script can be called to change the cursor visibility
    public static void setVisibility(bool visible) 
    {
        Cursor.visible = visible;
    }
}