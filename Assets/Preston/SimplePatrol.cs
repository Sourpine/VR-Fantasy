using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Code
{
    public class SimplePatrol : MonoBehaviour
    {
        [SerializeField]
        float _totalWaitTime = 3f;

        [SerializeField]
        float _switchProb = 0.2f;

        [SerializeField]
        List<Waypoint> _patrolPoints;


        NavMeshAgent _NavMeshAgent;
        ConnectedWaypoint _currentWaypoint;
        ConnectedWaypoint _previousWaypoint;

        bool _travelling;
        bool _waiting;
        float _waitTimer;
        int _waypointVisted;
        private bool _patrolWaiting;

        void Start()
        {
            _NavMeshAgent = this.GetComponent<NavMeshAgent>();
            if (_NavMeshAgent == null)
            {
                Debug.LogError("Bruh moment" + gameObject.name);
            }
            else
            {
                if (_currentWaypoint == null)
                {
                    GameObject[] allwaypoints = GameObject.FindGameObjectsWithTag("Waypoint");

                    if (allwaypoints.Length > 0)
                    {
                        while (_currentWaypoint == null)
                        {
                            int random = UnityEngine.Random.Range(0, allwaypoints.Length);
                            ConnectedWaypoint startingWaypoint = allwaypoints[random].GetComponent<ConnectedWaypoint>();

                            if (startingWaypoint != null)
                            {
                                _currentWaypoint = startingWaypoint;

                            }
                        }
                    }
                }
                else
                {
                    Debug.LogError("bruh moment 2");
                }
            }
            SetDestination();




        }





        // Update is called once per frame
        void Update()
        {
            if (_travelling && _NavMeshAgent.remainingDistance <= 1.0f)
            {
                _travelling = false;
                _waypointVisted++;

                if (_patrolWaiting)
                {
                    _waiting = true;
                }


                if (_waiting)
                {
                    _waitTimer += Time.deltaTime;
                    if (_waitTimer > -_totalWaitTime)
                    {
                        _waiting = false;
                        SetDestination();
                    }
                }
            }
        }
        private void SetDestination()
        {
            if(_waypointVisted > 0)
            {
                ConnectedWaypoint nextWaypoint = _currentWaypoint.NextWaypoint(_previousWaypoint);
                _previousWaypoint = _currentWaypoint;
                _currentWaypoint = nextWaypoint;
            }
            Vector3 targetVector = _currentWaypoint.transform.position;
            _NavMeshAgent.SetDestination(targetVector);
            _travelling = true;
        }

    }
   
   
}
