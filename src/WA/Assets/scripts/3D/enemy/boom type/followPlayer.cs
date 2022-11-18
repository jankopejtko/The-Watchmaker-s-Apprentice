using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followPlayer : MonoBehaviour
{
    [SerializeField] public GameObject follow;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.destination = follow.transform.position;
    }
}
