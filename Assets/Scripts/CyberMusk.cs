using UnityEngine;
using UnityEngine.AI;

public class CyberMusk : MonoBehaviour
{
    [SerializeField]
    private float MIN_DISTANCE = 3f;

    private NavMeshAgent _agent;
    private Transform _target;

    private Transform Target
    {
        get
        {
            if (_target == null)
            {
                _target = GameObject.FindGameObjectWithTag("Player").transform;
            }
            return _target;
        }
    }

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _agent.stoppingDistance = MIN_DISTANCE;
        _agent.SetDestination(Target.position);
    }

    private void FixedUpdate()
    {
        _agent.SetDestination(Target.position);
    }
}
