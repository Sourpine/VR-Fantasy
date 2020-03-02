using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSpell : MonoBehaviour
{
    public List<GameObject> targetList;
    public GameObject Hand;
    public GameObject lightningPrefab;
    public OVRInput.Button cast;
    public GameObject lineTest;
    public float lightningRange = 50;
    public LayerMask lightningMask;
    
    // Start is called before the first frame update
    void Start()
    {
        //Hand = gameObject;
        //lightningPrefab = Hand.GetComponent<NEWSpells>().FireAirPrefab;
    }

    // Update is called once per frame
    void Update()
    {
        //lightningPrefab = Hand.GetComponent<NEWSpells>().FireAirPrefab;

        RaycastHit zapHit;
        Ray lightningRay = new Ray(Hand.transform.position, Hand.transform.forward);

        //Debug.DrawRay(Hand.transform.position, Hand.transform.forward * lightningRange);
        
        if (Physics.Raycast(lightningRay, out zapHit, lightningRange, lightningMask, QueryTriggerInteraction.Ignore))
        {
            Debug.DrawLine(lightningRay.origin, zapHit.point, Color.red);

            //if (OVRInput.GetDown(cast)) { }
            targetList = new List<GameObject>();

            if (zapHit.collider.gameObject.tag == "Enemy")
            {
                GameObject go = zapHit.collider.gameObject;
                targetList.Add(go);
                foreach (GameObject target in targetList)
                {
                    List<GameObject> nearby = target.GetComponent<NearbyEnemy>().nearby;
                    foreach(GameObject g in nearby)
                    {
                        if (!targetList.Contains(g) && targetList.Count < 6)
                        {
                            targetList.Add(g);
                        }
                        if (targetList.Count >= 6)
                        {
                            break;
                        }
                    }
                    if (targetList.Count >= 6)
                    {
                        break;
                    }
                }
            }
            GameObject lightning = Instantiate(lightningPrefab, Hand.transform.position, Hand.transform.rotation);
            //lightning.transform.forward = -Hand.transform.forward;
            lightning.transform.right = Vector3.Normalize(targetList[0].transform.position - Hand.transform.position);
            for (int i = 1; i < targetList.Count; i++)
            {
                GameObject light = Instantiate(lightningPrefab, targetList[i].transform.position, Quaternion.identity);
                light.transform.right = Vector3.Normalize(targetList[i].transform.position - targetList[i - 1].transform.position);
                lineTest.transform.position = targetList[i - 1].transform.position;
            }
        }
        else
        {
            Debug.DrawLine(lightningRay.origin, lightningRay.origin + lightningRay.direction * lightningRange, Color.green);
        }

        //test stuffs
        for (int i = 1; i < targetList.Count; i++)
        {
            lineTest.transform.position = targetList[i - 1].transform.position;
        }
    }
}
