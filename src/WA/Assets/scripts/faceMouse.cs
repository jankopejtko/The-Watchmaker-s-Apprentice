using UnityEngine;

public class faceMouse : MonoBehaviour
{
    [SerializeField] Camera cam;
    void Update()
    {
        face();
    }
    void face() 
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector2 direction = new Vector2
        (
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;
    }
}
