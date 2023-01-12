using UnityEngine;

public class setHand : MonoBehaviour
{
    [SerializeField] activation activation;
    [SerializeField] GameObject hand;
    [SerializeField] float defaultYRotation, newYRotation;
    Quaternion target;
    void Update()
    {
        if (activation.active)
        {
            target = Quaternion.Euler(-90, newYRotation, 0);
        }
        else
        {
            target = Quaternion.Euler(-90, defaultYRotation, 0);
        }
        hand.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 5f);
    }
}
//todo comment code