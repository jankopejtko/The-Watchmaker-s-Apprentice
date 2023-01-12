using UnityEngine;

public class checkActive : MonoBehaviour
{
    public activation activation;
    public pendulumRotate rotate;
    void Update()
    {
        if(activation.active == true) 
        {
            rotate.enabledRotation = false; 
        }
        else
        {
            rotate.enabledRotation = true;
        }
    }
}
//todo comment code