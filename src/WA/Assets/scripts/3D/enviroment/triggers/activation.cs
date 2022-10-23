//Jan Kopejtko, 2022

using UnityEngine;

public class activation : MonoBehaviour
{
    public bool active = false; //trigger if trigger collides with object
    public string objectTag; //object tag with trigger collides
    void Start()
    {
        active = false; //reset trigger on first frame
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == objectTag)
        {
            active = true;
            Debug.Log("trigger activated");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == objectTag)
        {
            active = false;
            Debug.Log("trigger deactivated");
        }
    }
    public bool GetState() 
    {
        return active;
    }
}
