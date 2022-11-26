//Jan Kopejtko, 2022

using System.Collections.Generic;
using Debug = UnityEngine.Debug;
using UnityEngine.AI;
using UnityEngine;

public class movePointToPoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> points = new List<GameObject>();
    private NavMeshAgent agent;
    public int speed;
    int i;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        i = 0;
    }
    // Update is called once per frame
    void Update()
    {
        agent.destination = points[i].transform.position;
        if (!agent.pathPending)
        {
            if(agent.remainingDistance <= agent.stoppingDistance) 
            {
                Debug.Log("destination swap");
                i++;
                if (i >= points.Count)
                {
                    Debug.Log("loop reset");
                    i = 0;
                }
            }
        }
    }
}
