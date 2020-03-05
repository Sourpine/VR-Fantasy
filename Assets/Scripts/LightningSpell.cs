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
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        Hand = gameObject;
        lightningPrefab = Hand.GetComponent<NEWSpells>().FireAirPrefab;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(GameObject.Find("New Game Object"));

        lightningPrefab = Hand.GetComponent<NEWSpells>().FireAirPrefab;

        RaycastHit zapHit;
        Ray lightningRay = new Ray(Hand.transform.position, Hand.transform.forward);

        //Debug.DrawRay(Hand.transform.position, Hand.transform.forward * lightningRange);
        
        if (Physics.Raycast(lightningRay, out zapHit, lightningRange, lightningMask, QueryTriggerInteraction.Ignore))
        {
            Debug.DrawLine(lightningRay.origin, zapHit.point, Color.red);

            if (OVRInput.GetDown(cast) && Hand.GetComponent<NEWSpells>().mana >= Hand.GetComponent<NEWSpells>().FACostI && Hand.GetComponent<NEWSpells>().valueSave + Hand.GetComponent<NEWSpells>().OtherHand.GetComponent<NEWSpells>().valueSave == 501  /* || Input.GetButtonDown("Fire1") */)
            {
                player.GetComponent<Mana>().mana -= Hand.GetComponent<NEWSpells>().FACostI;
                targetList = new List<GameObject>();

                if (zapHit.collider.gameObject.tag == "Enemy")
                {
                    GameObject go = zapHit.collider.gameObject;
                    targetList.Add(go);
                    foreach (GameObject target in targetList)
                    {
                        List<GameObject> nearby = target.GetComponent<NearbyEnemy>().nearby;
                        foreach (GameObject g in nearby)
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
                lightning.transform.forward /*right*/ = Vector3.Normalize(targetList[0].transform.position - Hand.transform.position);
                lightning.SetActive(true);
                for (int i = 1; i < targetList.Count; i++)
                {
                    GameObject t = new GameObject();
                    //t.transform.LookAt(targetList[i].transform);
                    GameObject light = Instantiate(lightningPrefab, targetList[i - 1].transform.position, Quaternion.identity);
                    light.SetActive(true);
                    light.transform.forward /*right*/ = Vector3.Normalize(targetList[i].transform.position - targetList[i - 1].transform.position);
                    lineTest.transform.position = targetList[i - 1].transform.position;
                    Destroy(light, .5f);
                }
                Destroy(lightning, .5f);
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
