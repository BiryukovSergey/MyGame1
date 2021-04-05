using UnityEngine;
using UnityEngine.AI;

public class NavEnemy : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent _agent;
    [SerializeField]
    private Transform[] _position;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(_position[1].position);
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position, _position[0].position) < 1.0f)
        {
            _agent.SetDestination(_position[1].position);
        }
        else if (Vector3.Distance(transform.position, _position[1].position) < 1.0f)
        {
            _agent.SetDestination(_position[2].position);
        }
        else if (Vector3.Distance(transform.position, _position[2].position) < 1.0f)
        {
            _agent.SetDestination(_position[0].position);
        }

    }
}
