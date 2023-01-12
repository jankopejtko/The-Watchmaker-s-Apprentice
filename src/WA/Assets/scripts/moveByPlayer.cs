//Jan Kopejtko, 2022

using UnityEngine;

public class moveByPlayer : MonoBehaviour
{
    GameObject placeHolder;
    [SerializeField] activation activation;
    [SerializeField] GameObject parent;
    Rigidbody rb;
    bool inUse;
    private void Start()
    {
        rb = parent.GetComponent<Rigidbody>();
        placeHolder = GameObject.FindGameObjectsWithTag("PlayerPlaceHolder")[0];
    }
    private void Update()
    {
        if (activation.active == true) 
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                inUse = !inUse;
            }
            if (inUse)
            {
                rb.useGravity = false;
                parent.transform.position = placeHolder.transform.position;
            }
            else 
            {
                rb.angularVelocity = Vector3.zero;
                rb.useGravity = true;
            }
        }
    }
}
//todo comment code