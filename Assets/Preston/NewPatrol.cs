using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NewPatrol : MonoBehaviour
{
    [SerializeField]
    bool _patrolWaiting;

    [SerializeField]
    float _totalWaitTime = 3f;

    [SerializeField]
    float _switchProbability = 0.2f;

    [SerializeField]
    List<Waypoint> _patrolPoints;

    NavMeshAgent _navMeshAgent;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
