using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    private int randomSpot;

     void Start()
    {
        randomSpot = Random.Range(0, moveSpots.Length);
            
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
    }
}
