using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCam : MonoBehaviour
{

    public GameObject cameraToLookAt;
    public bool away;
    void Start()
    {
        //transform.Rotate( 180,0,0 );
    }

    void Update()
    {
        Vector3 v = cameraToLookAt.transform.position - transform.position;
        v.x = v.z = 0.0f;
        if (!away)
        {
            transform.LookAt(cameraToLookAt.transform.position - v);
            transform.Rotate(0, 180, 0);
        }
        else
        {
            transform.LookAt(cameraToLookAt.transform.position - v);
            transform.Rotate(0, 0, 0);
        }
        
    }
}
