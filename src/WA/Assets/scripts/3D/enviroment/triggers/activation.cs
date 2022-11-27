//Jan Kopejtko, 2022

using UnityEngine;

//GO = GameObject
//THIS = gameobject that this script is attached to

//Main goal of this script is to determine if GO entered/quitted THIS collider

public class activation : MonoBehaviour
{
    public bool active = false; //trigger if trigger collides with object
    [SerializeField] public string objectTag; //object tag with trigger collides
    void Awake()
    {
        active = false; //reset trigger on first frame
    }
    private void OnTriggerEnter(Collider other) //this method will check if THIS collider enter collision with something
    {
        if (other.tag == objectTag) //check if THIS GO collide with something that have required tag
        {
            active = true; //set THIS state as active
            Debug.Log("trigger activated");
        }
    }
    private void OnTriggerExit(Collider other) //this method will check if THIS collider exit collision with something
    {
        if (other.tag == objectTag) //check if THIS GO collide with something that have required tag
        {
            active = false; //set THIS state as inactive
            Debug.Log("trigger deactivated");
        }
    }
    public bool GetState() //return THIS state
    {
        return active;
    }
}
