using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMaster : MonoBehaviour
{
    public GameObject Foot1;
    public GameObject Foot2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Step1()
    {
        Foot1.GetComponent<BossSteps>().bruh();
    }
    void Step2()
    {
        Foot2.GetComponent<BossSteps>().bruh();
    }
}
