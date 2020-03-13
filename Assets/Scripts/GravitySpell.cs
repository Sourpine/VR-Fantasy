using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySpell : MonoBehaviour
{
    public float gravityMod = 1;
    public float gravNorm = 1;
    public float gravNeg = -1.5f;
    public float gravFall = 40;
    public bool inSpell = false;
    public bool castDown = false;
    //public bool hasCast = false;
    public GameObject player;
    public float floatTime = 2.5f;
    public float floatTime2 = 4.5f;
    public float floatTime3 = 5.5f;
    public float floatTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gravNorm = 1;
        gameObject.GetComponent<Rigidbody>().AddForce(Physics.gravity * gravNorm);
        gravNeg = -1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameObject.GetComponent<Rigidbody>().AddForce(Physics.gravity * gravityMod);

        if (floatTimer >= floatTime)
        {
            castDown = false;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        }
        if (floatTimer >= floatTime2)
        {
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            gameObject.GetComponent<Rigidbody>().AddForce(-transform.up * 50, ForceMode.Impulse);
            gravityMod = gravFall;
        }
        if (floatTimer >= floatTime3)
        {
            inSpell = false;
            floatTimer = 0;
        }

        if (inSpell == true)
        {
            floatTimer += Time.deltaTime;
            if (castDown == true && floatTimer < floatTime)
            {
                gravityMod = gravNeg;
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
                gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                gameObject.GetComponent<Animator>().enabled = false;
            }
        }
        else
        {
            gravityMod = gravNorm;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "EarthAirPrefab" || other.name == "EarthAirPrefab(Clone)")
        {
            inSpell = true;
            castDown = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "EarthAirPrefab" || other.name == "EarthAirPrefab(Clone)")
        {
            castDown = false;
        }
    }
}
