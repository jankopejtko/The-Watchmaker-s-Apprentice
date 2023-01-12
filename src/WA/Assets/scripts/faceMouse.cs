//Jan Kopejtko, 2023
using UnityEngine;

// this script will take THIS gameObject and rotate it to face the mouse position
public class faceMouse : MonoBehaviour
{
    [SerializeField] Camera cam; //get camera from unity inspector
    void Update() //check every frame
    {
        Vector3 mousePosition = Input.mousePosition; // get mouse position and store it as mousePosition
        Vector2 direction = mousePosition - transform.position; // new 2D vector pointing to the mouse position
        transform.up = direction; // THIS gameObject transform will now be faceing the mouse
    }
}