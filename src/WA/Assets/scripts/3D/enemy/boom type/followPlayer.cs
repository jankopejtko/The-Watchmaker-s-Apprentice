//Jan Kopejtko, 2022

using UnityEngine.AI;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    GameObject follow;
    private NavMeshAgent agent;

    private void Start()
    {
        follow = GameObject.Find("Player");
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.destination = follow.transform.position;
    }
}
