using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    [SerializeField] activation activation;
    void Update()
    {
        if (activation.GetState())
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
        else 
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
