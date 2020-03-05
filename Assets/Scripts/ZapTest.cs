using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZapTest : MonoBehaviour
{
    public GameObject zap;
    public GameObject zapSpawn;
    public List<GameObject> zapTargets;
    public LayerMask zapMask;
    public float zapLength = 100;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray zapRay = new Ray(transform.position, transform.forward);
        RaycastHit zapHit;

        if(Physics.Raycast (zapRay, out zapHit, 100, zapMask))
        {
            Debug.DrawLine(zapRay.origin, zapHit.point, Color.red);
        }
        else
        {
            Debug.DrawLine(zapRay.origin, zapRay.origin + zapRay.direction * 100, Color.green);
        }
    }
}
