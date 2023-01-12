using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour
{
    public GameObject player;
    private Camera lookAt;
    private void Start()
    {
        lookAt = player.GetComponent<Camera>();
    }
    void Update()
    {
        transform.LookAt(lookAt.transform.position);
    }
}
//todo comment code