using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ParticleSpawning : MonoBehaviour
{
    public ParticleSystem part;
    public GameObject prefab;
    public List<ParticleCollisionEvent> collisionEvents;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }
    
    void OnParticleCollision(GameObject other)
    {
        int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);
        Debug.Log("collision here!");
        
        int i = 0;
        if(GameObject.FindGameObjectWithTag("RainPart") != null)
        {
            return;
        }
        while (i < numCollisionEvents)
        {
            Instantiate(prefab, collisionEvents[i].intersection, Quaternion.identity);
            return;
            i++;
        }
    }
}