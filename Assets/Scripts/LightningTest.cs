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

    //public int[] lightningArray;
    //public GameObject[] targetsArray;
    //public int arrayLength = 0;
    public List<GameObject> targetList;
    public GameObject LHand;
    public GameObject lightningPrefab;
    public GameObject LLHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1") && Physics.Raycast(LHand.transform.position, LHand.transform.forward, out hit, 50))
        {
            Debug.Log("HIT");
            targetList = new List<GameObject>();
            //the raycast is hitting and logging that it is hitting but it doesn't track what it is hitting
            Debug.Log(hit.collider.gameObject.name);
            
            if(hit.collider.gameObject.tag == "Enemy")
            {
                Debug.Log("HIT");
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
            GameObject lightning = Instantiate(lightningPrefab, LHand.transform.position, Quaternion.identity);
            lightning.transform.forward = -LHand.transform.forward;
            lightning.transform.right = Vector3.Normalize(targetList[0].transform.position - LHand.transform.position);
            for(int i = 1; i < targetList.Count; i++)
            {
                GameObject light = Instantiate(lightningPrefab, targetList[i].transform.position, Quaternion.identity);
                light.transform.right = Vector3.Normalize(targetList[i].transform.position - targetList[i-1].transform.position);
            }
        }
    }
}
