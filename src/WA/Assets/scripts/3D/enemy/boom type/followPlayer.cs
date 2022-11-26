//Jan Kopejtko, 2022

using UnityEngine.AI;
using UnityEngine;

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
