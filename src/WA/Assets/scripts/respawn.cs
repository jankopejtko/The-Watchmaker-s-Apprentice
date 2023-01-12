using System.Drawing;
using UnityEditor;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField] GameObject parent;
    GameObject spawnLocation;
    private void Start()
    {
        spawnLocation = GameObject.FindGameObjectsWithTag("weightSpawnPoint")[0];
    }
    private void Update()
    {
        if (parent.transform.position.y < -10) 
        {
            parent.transform.localPosition = spawnLocation.transform.localPosition;
        }
    }
}
//todo comment code