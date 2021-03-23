using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    public NavMeshAgent agent;
    
    public Transform firstPoint;
    public Transform secondPoint;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(firstPoint.position);
    }

    private void Update()
        
        
    {
            if (Vector3.Distance(transform.position, firstPoint.position) <1.0f)
            {
                agent.SetDestination(secondPoint.position);
            }
            else if (Vector3.Distance(transform.position, secondPoint.position) < 1.0f)
            {
                agent.SetDestination(firstPoint.position);
            }
                
    }

}
