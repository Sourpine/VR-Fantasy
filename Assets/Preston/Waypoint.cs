using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Color WaypointColor;
    [SerializeField]
    protected float debugDrawRadius = 1.0f;

    public virtual void OnDrawGizmos()
    {
        Gizmos.color = WaypointColor;
        Gizmos.DrawWireSphere(transform.position, debugDrawRadius);
    }
}
