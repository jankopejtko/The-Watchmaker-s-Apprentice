//Jan Kopejtko, 2022

using Random = UnityEngine.Random;
using UnityEngine;
using System;

public class pendulumRotate : MonoBehaviour
{
    [SerializeField] float maximumAngle;
    [SerializeField] [Range(0, 10)] float delay;
    [SerializeField] [Range (1,5)] float speed;
    public bool enableRandomDelay;
    public bool enabledRotation = true;
    private void Start()
    {
        if (enableRandomDelay) 
        {
            delay = Random.Range(0, 10);
        }
    }
    void FixedUpdate()
    {
        if (enabledRotation) 
        {
            transform.localRotation = Quaternion.Euler(maximumAngle * MathF.Sin((Time.time + delay) * speed) , 0f, 0f);
        }
        else 
        {
            transform.localRotation = Quaternion.Euler(75,0,0);
        }
    }
}