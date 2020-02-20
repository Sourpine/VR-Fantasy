using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;
    public string spellName = "null";

    public float dpsTime = 1;
    public float dpsTimer = 0;
    public bool dps = false;

    private Animator EnemyController;
    // Start is called before the first frame update
    void Start()
    {
        EnemyController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dps = false;
        //should have a death animation
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        dpsTimer += Time.deltaTime;
        if(dpsTimer >= dpsTime)
        {
            dps = true;
            dpsTime = 0;
        }
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "spell")
        {
            //health--;
            EnemyController.SetTrigger("Struck");
            spellName = gameObject.name;
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "spell")
        {
            //health--;
            EnemyController.SetTrigger("Struck");
            spellName = gameObject.name;
        }
        
        switch (spellName)
        {
            case "EarthPrefab": //also may need to acount for clones
                health -= 20;
                break;
            case "FirePrefab":
                health -= 7;
                //5 tic
                break;

            //combos x2's
            case "Earthx2Prefab":
                health -= 85;
                break;
            case "Firex2Prefab":
                health -= 60;
                //10 tic
                break;
            case "Airx2Prefab":
                health -= 5;
                //5 tic
                break;
            //other combos
            case "EarthFire":
                health -= 10;
                //10 tic
                //10 sec
                break;
            case "EarthWater":
                //slowing
                break;
            case "EarthAir":
                health -= 90;
                break;
            case "FireWater":
                health -= 5;
                //5 tic
                //slowing
                break;
            case "FireAir":
                health -= 75;
                break;
            case "WaterAir":
                health -= 75;
                break;
        }


    }

    private void OnTriggerStay(Collider other)
    {
        switch (spellName)
        {
            case "FirePrefab":
                if (dps == true)
                {
                    health -= 5;
                }
                break;

            //combos x2's
            case "Firex2Prefab":
                if (dps == true)
                {
                    health -= 10;
                }
                break;
            case "Airx2Prefab":
                if (dps == true)
                {
                    health -= 5;
                }
                break;
            //other combos
            case "EarthFire":
                if (dps == true)
                {
                    health -= 10;
                }
                //10 sec
                break;
            case "EarthWater":
                //slowing
                break;
            case "FireWater":
                if (dps == true)
                {
                    health -= 5;
                }
                //slowing
                break;
        }
    }


    /*
    e = i 
    f = c
    w = none
    a = none

    ee = i
    ff = i
    ww = none
    aa = c

    ef = c
    ew = c
    ea = i (with delay)
    fw = c
    fa = i
    wa = i
    */
}
