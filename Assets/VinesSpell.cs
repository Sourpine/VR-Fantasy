using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VinesSpell : MonoBehaviour
{
    public float moveSpeed;
    public float moveSpeedSave = 0;
    public GameObject player;
    public bool active = false;
    public bool slowed = false;
    public float slowAmnt = 6;
    public float time = 8;
    public float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        moveSpeed = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed;
        moveSpeedSave = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed;
        slowAmnt = 6;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = moveSpeed;

        if (active == true)
        {
            if(slowed == false)
            {
                moveSpeed /= slowAmnt;
            }
            slowed = true;
            timer += Time.deltaTime;
        }
        else
        {
            moveSpeed = moveSpeedSave;
            slowed = false;
        }
        if(timer >= time)
        {
            active = false;
            slowed = false;
            timer = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "EarthWaterPrefab" || other.name == "EarthWaterPrefab(Clone)")
        {
            active = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "EarthWaterPrefab" || other.name == "EarthWaterPrefab(Clone)")
        {
            active = false;
            slowed = false;
        }
    }
}
