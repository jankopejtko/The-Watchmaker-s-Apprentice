//Jan Kopejtko, 2023

using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject GO;
    [SerializeField] bool rotating = true;
    public static int direction = 1;

    private void Update()
    {
        if (!rotating) { return; }
        else GO.transform.Rotate(0f, direction * Time.deltaTime * speed, 0f);
    }
    public static void ChangeDirection(bool Bdirection) //true - right, false - left 
    {
        if (Bdirection)
        {
            direction = 1;
        }
        else direction = -1;
    }
}