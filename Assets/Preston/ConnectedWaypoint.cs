using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConnectedWaypoint : MonoBehaviour
{
    [SerializeField]
    protected float _connectivityRadius = 50f;
    protected float debugDrawRadius = 1.0f;

    List<ConnectedWaypoint> _connections;

    void Start()
    {
        GameObject[] allwaypoints = GameObject.FindGameObjectsWithTag("WayPoint");

        


        _connections = new List<ConnectedWaypoint>();



        for (int i = 0; i < allwaypoints.Length; i++)
        {
            ConnectedWaypoint nextWaypoint = allwaypoints[i].GetComponent<ConnectedWaypoint>();



            if (nextWaypoint != null)
            {
                if (Vector3.Distance(this.transform.position, nextWaypoint.transform.position) <= _connectivityRadius && nextWaypoint != this)
                {
                    _connections.Add(nextWaypoint);
                }
            }
        }
    }   

    public virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, debugDrawRadius);


        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, _connectivityRadius);

    }
    public ConnectedWaypoint NextWaypoint (ConnectedWaypoint previousWaypoint)
    {
        if (_connections.Count == 0)
        {
            Debug.LogError("Insufficient Waypoint count.");
            return null;
        }
        else if(_connections.Count == 1 && _connections.Contains(previousWaypoint))
        {
            return previousWaypoint;
        }else
        {
            ConnectedWaypoint nextWaypoint;
            int nextIndex = 0;

            do
            {
                nextIndex = UnityEngine.Random.Range(0, _connections.Count);
                nextWaypoint = _connections[nextIndex];
            } while (nextWaypoint == previousWaypoint);
            return nextWaypoint;  
        }

    }






    // Update is called once per frame
    void Update()
    {

    }
}
