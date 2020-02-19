using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public Transform moveSpots;
    private int randomSpot;
    public float startWaitTime;
    private float WaitTime;
    public float maxX;
    public float minX;
    public float minY;
    public float maxY;
    public Animator bruh;
     void Start()
    {
        WaitTime = startWaitTime;
        moveSpots.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
        
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpots.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, moveSpots.position) < 0.2f)
        {
            if(WaitTime <= 0)
            {
                moveSpots.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
                WaitTime = startWaitTime;
                bruh.SetBool("Waiting?", false);
            }
            else
            {
                WaitTime -= Time.deltaTime;
                bruh.SetBool("Waiting?", true);
            }
        }
    }
}
