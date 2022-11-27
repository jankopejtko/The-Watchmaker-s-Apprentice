//Jan Kopejtko, 2022

using UnityEngine;

public class collisionDestroy : MonoBehaviour
{
    [SerializeField] GameObject destroy;
    [SerializeField] string tag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == destroy.tag)
        {
            Debug.Log("object destroyed");
            Destroy(destroy);
            if (destroy.tag == tag)
            {
                FindObjectOfType<event_manager>().EndGame();
            }
        }
        else Debug.Log("tag not prefered");
    }
}
