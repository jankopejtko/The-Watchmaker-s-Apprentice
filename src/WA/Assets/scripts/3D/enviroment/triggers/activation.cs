using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;

public class activation : MonoBehaviour
{
    public bool active = false;
    public string objectTag;
    void Start()
    {
        active = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == objectTag) 
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
}
