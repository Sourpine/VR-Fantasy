using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCpatrol : MonoBehaviour
{
    [SerializeField]
    bool patrolWaiting;
    [SerializeField]
    float totalWaitTime = 3f;

    [SerializeField]
    float switchProbability = 0.2f;

    [SerializeField]
    List<Waypoint> patrolPoints;

    NavMeshAgent _navMeshAgent;
    int _currentPatrolIndex;
    bool travelling;
    bool _waiting;
    bool patrolForward;
    float waitTimer;

    // Start is called before the first frame update
   public void FixedUpdate()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        if(_navMeshAgent == null)
        {
            Debug.LogError("bruh" + gameObject.name);
        }
        else
        {
            if(patrolPoints != null && patrolPoints.Count >= 2)
            {
                _currentPatrolIndex = 0;
                SetDestination();
            }
            else
            {
                Debug.Log("Bruh moment");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(travelling && _navMeshAgent.remainingDistance <= 1.0f)
        {
            travelling = false;

            if(patrolWaiting)
            {
                _waiting = true;
                waitTimer = 0f;

            }
            else
            {
                ChangePatrolPoint();
                SetDestination();
            }
        }
        if(_waiting )
        {
            waitTimer += Time.deltaTime;
            if(waitTimer >= totalWaitTime)
            {
                _waiting = false;
                ChangePatrolPoint();
                SetDestination();
            }
        }
    }
    private void SetDestination()
    {
        if(patrolPoints != null)
        {
            Vector3 targetVector = patrolPoints[_currentPatrolIndex].transform.position;
            _navMeshAgent.SetDestination(targetVector);
            travelling = true;
        }
    }

    private void ChangePatrolPoint()
    {
        if(UnityEngine.Random.Range(0f, 1f)<= switchProbability)
        {
            patrolForward = !patrolForward;
        }
        if(patrolForward)
        {
            _currentPatrolIndex = (_currentPatrolIndex + 1) % patrolPoints.Count;
        }
        else
        {
            if(--_currentPatrolIndex < 0)
            {
                _currentPatrolIndex = patrolPoints.Count - 1;
            }
        }
    }
}
