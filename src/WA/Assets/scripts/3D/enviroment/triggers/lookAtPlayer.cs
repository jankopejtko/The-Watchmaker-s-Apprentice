using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        transform.LookAt(player.transform.position);
    }
}
