using System.Collections;
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

    public int[] lightningArray;
    public GameObject[] targetsArray;
    public int arrayLength = 0;
    public List<GameObject> targetList;
    public GameObject LHand;

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
        }
        Debug.Log(arrayLength);
        //  targetsArray[].length = arrayLength;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            arrayLength++;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            arrayLength--;
        }
    }
}
