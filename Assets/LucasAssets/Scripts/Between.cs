using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Between : MonoBehaviour
{
    public Transform pt1;
    public Transform pt2;
    public bool lastpoint;
    float timer;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= waitTime)
        {
            if (lastpoint)
            {
                transform.position = pt1.position;
                lastpoint = false;
            }
            else if (!lastpoint)
            {
                transform.position = pt2.position;
                lastpoint = true;
            }
        }
        else
        {
            if (!lastpoint)
            {
                transform.position = pt1.position;
            }
            else if (lastpoint)
            {
                transform.position = pt2.position;
            }
        }
    }
}
