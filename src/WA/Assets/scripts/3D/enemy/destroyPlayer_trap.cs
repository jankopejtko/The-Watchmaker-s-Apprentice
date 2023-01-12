using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPlayer_trap : MonoBehaviour
{
    GameObject Player;
    [SerializeField] string tag;

    private void Start()
    {
        Player = GameObject.Find(tag);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Player.tag)
        {
            Debug.Log("object destroyed");
            Destroy(Player);
            FindObjectOfType<event_manager>().EndGame();
        }
    }
}
//todo comment code