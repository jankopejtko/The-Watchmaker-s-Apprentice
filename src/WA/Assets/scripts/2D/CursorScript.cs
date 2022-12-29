using UnityEngine;

public class CursorScript : MonoBehaviour
{
    [SerializeField] bool visible;
    // Use this for initialization
    void Start()
    {
        //Set Cursor visibility
        Cursor.visible = visible;
    }
}