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
        if (activation.active) 
        {
            waitSeconds = defaultWaitSeconds;
        }
        if (waitSeconds > 0 && !activation.active)
        {
            Debug.Log(waitSeconds);
            waitSeconds -= Time.deltaTime;
            if (waitSeconds < 0) 
            {
                activation.active = false;
            }
        }
    }
}
