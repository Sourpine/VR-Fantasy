﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningTest : MonoBehaviour
{
   // public GameObject target;
   // public GameObject T0;
   // public GameObject T1;
   // public GameObject T2;
   // public GameObject T3;
   // public GameObject T4;
   // public GameObject T5;

    //public int[] lightningArray;
    //public GameObject[] targetsArray;
    //public int arrayLength = 0;
    public List<GameObject> targetList;
    public GameObject LHand;
    public GameObject lightningPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //for(int)
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1") && Physics.Raycast(LHand.transform.position, LHand.transform.forward, out hit, 50))
        {
            Debug.Log("HIT");
            targetList = new List<GameObject>();
            
            if(hit.collider.gameObject.tag == "Enemy")
            {
                GameObject go = hit.collider.gameObject;
                targetList.Add(go);
                foreach(GameObject target in targetList)
                {
                    List<GameObject> nearby = target.GetComponent<NearbyEnemy>().nearby;
                    foreach(GameObject g in nearby)
                    {
                        if(!targetList.Contains(g) && targetList.Count < 6)
                        {
                            targetList.Add(g);
                        }
                        if (targetList.Count >= 6)
                        {
                            break;
                        }
                    }
                    if(targetList.Count >= 6)
                    {
                        break;
                    }
                }
            }
            Debug.Log(targetList);
            //instantiate prefab between self and first on nearby list (or self and go)
            GameObject lightning = Instantiate(lightningPrefab, transform.position, Quaternion.identity);
            lightning.transform.right = Vector3.Normalize(targetList[0].transform.position - transform.position);
            for(int i = 1; i < targetList.Count; i++)
            {
                GameObject light = Instantiate(lightningPrefab, targetList[i].transform.position, Quaternion.identity);
                light.transform.right = Vector3.Normalize(targetList[i].transform.position - targetList[i-1].transform.position);
            }
            //do the same between first and second, second and third, and so on till all in list have been hit
        }
        //Debug.Log(targetList);
    }
}
