//Jan Kopejtko, 2022

using UnityEngine;

//GO = Game Object
//THIS = this gameobject that this script is attached to

//this script is for boomber type enemy that will disable its movemnt if approached Player

public class destroySelf : MonoBehaviour
{
    [SerializeField] GameObject parent; //parent of THIS GO
    [SerializeField] private string objectTag; //tag of GO that will collide with THIS
    [SerializeField] private int TTL; //time to live in seconds
    private followPlayer FP; //followPlayer script that will be disabled
    private void Start()
    {
        FP = parent.GetComponent<followPlayer>(); //find followPlayer script in parent GO
    }
    private void OnTriggerEnter(Collider other) //this method will check if THIS collider enter collision with something
    {
        if (other.tag == objectTag) //check if THIS GO collide with something that have required tag
        {
            FP.enabled = false; //disable enemy movment
            Debug.Log("BOOM!");
            Destroy(parent, TTL); //destroy parent GO after TTL
        }
    }
}
