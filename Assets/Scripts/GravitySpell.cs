using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySpell : MonoBehaviour
{
    public float gravityMod = 1;
    public float gravNorm = 1;
    public float gravNeg = -1.1f;
    public float gravFall = 5;
    public bool inSpell = false;
    public bool castDown = false;
    public GameObject player;
    public float floatTime = 5;
    public float floatTime2 = 8;
    public float floatTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gravNorm = 1;
        gameObject.GetComponent<Rigidbody>().AddForce(Physics.gravity * gravNorm);
        gravNeg = -1.1f;
        gravFall = 5;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Physics.gravity * gravityMod);

        if (floatTimer >= floatTime)
        {
            gravityMod = gravFall;
        }
        if (floatTimer >= floatTime2)
        {
            inSpell = false;
            castDown = false;

            floatTimer = 0;
        }

        /*if (OVRInput.GetDown(player.GetComponent<NEWSpells>().cast))
        {
            castDown = true;
        }*/
        if (inSpell == true && castDown == true)
        {
            //Debug.Log("Not Here 1");
            floatTimer += Time.deltaTime;
            gravityMod = gravNeg;
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;
            //Debug.Log("Not Here 2");
        }
        else
        {
            //Debug.Log("Not Here 3");
            gravityMod = gravNorm;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
            //Debug.Log("Not Here 4");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "EarthAirPrefab")
        {
            inSpell = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "EarthAirPrefab")
        {
            inSpell = false;
        }
    }
}
