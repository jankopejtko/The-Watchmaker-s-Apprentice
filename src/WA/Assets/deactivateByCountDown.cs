using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivateByCountDown : MonoBehaviour
{
    public activation activation;
    [SerializeField] private float defaultWaitSeconds;
    float waitSeconds;
    private void Start()
    {
        waitSeconds = defaultWaitSeconds;
    }
    void Update()
    {
        if (waitSeconds > 0)
        {
            waitSeconds -= Time.deltaTime;
        }
        else 
        {
            activation.active = false;
        }
    }
}
