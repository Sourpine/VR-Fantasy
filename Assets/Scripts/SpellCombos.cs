using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCombos : MonoBehaviour
{
    public int leftHand = 0;
    public int rightHand = 0;
    public GameObject leftWheel;
    public GameObject rightWheel;
    public bool combo = false;
    public GameObject ESL;
    public GameObject ESR;
    public GameObject player;
    public bool rIn = false;
    public bool lIn = false;
    public GameObject LHand;
    public GameObject RHand;
    public int LHSave = 0;
    public int RHSave = 0;
    
    //test items (may be removed in time)

    public GameObject FireL;
    public GameObject EarthL;
    public GameObject WaterL;
    public GameObject AirL;
    //public GameObject SwordL;

    public GameObject FireR;
    public GameObject EarthR;
    public GameObject WaterR;
    public GameObject AirR;
    //public GameObject SwordR;

    //x2's
    public GameObject FireballC;
    public GameObject MeteorC;
    public GameObject GrHealC;
    public GameObject CycloneC;

    //different spells c
    public GameObject LavaC;
    public GameObject GravityC;
    public GameObject LifeC;
    public GameObject GeyserC;
    public GameObject LightningC;
    public GameObject IceC;

    //shoot test variables
    public Camera camera;

    public GameObject rockPrefab;
    public GameObject firePrefab;
    public GameObject icePrefab;
    public float bulletSpeed;

    public float rayLength = 50.0f;

    public OVRInput.Button shootingbutton;

    // Start is called before the first frame update
    void Start()
    {
        leftHand = 0;
        rightHand = 0;
    }

    // Update is called once per frame
    void Update()
    {
        

        //menu pop-up
        if (Input.GetButtonDown("Oculus_CrossPlatform_PrimaryThumbstick") && leftWheel.activeSelf == false)
        {
            ESR.SetActive(false);
            rightWheel.SetActive(false);
            ESL.SetActive(true);
            leftWheel.SetActive(true);
        }
        else if (Input.GetButtonDown("Oculus_CrossPlatform_PrimaryThumbstick") && leftWheel.activeSelf == true)
        {
            ESL.SetActive(true);
            leftWheel.SetActive(false);
        }
        if (Input.GetButtonDown("Oculus_CrossPlatform_SecondaryThumbstick") && rightWheel.activeSelf == false)
        {
            ESL.SetActive(false);
            leftWheel.SetActive(false);
            ESR.SetActive(true);
            rightWheel.SetActive(true);

        }
        else if (Input.GetButtonDown("Oculus_CrossPlatform_SecondaryThumbstick") && rightWheel.activeSelf == true)
        {
            ESR.SetActive(true);
            rightWheel.SetActive(false);
        }
        //movement turned off
        if(rightWheel.activeSelf == true || leftWheel.activeSelf == true)
        {
            player.GetComponent<OVRPlayerController>().enabled = false;
        }
        else if (rightWheel.activeSelf == false && leftWheel.activeSelf == false)
        {
            player.GetComponent<OVRPlayerController>().enabled = true;
        }

        //determines left hand spell

        //Debug.Log(leftHand);
        switch (leftHand)
        {
            case 0:
                //empty
                
                break;
            case 1:
                //1 = earth (stun)
                ResetLeft();
                EarthL.SetActive(true);
                if (Input.GetButtonDown("Oculus_CrossPlatform_PrimaryIndexTrigger") || Input.GetButtonDown("Fire1"))
                {
                    RaycastHit hit;
                    Vector3 destination;
                    if (Physics.Raycast(LHand.transform.position, LHand.transform.forward, out hit, 50))
                    {
                        destination = hit.point;
                    }
                    else
                    {
                        destination = LHand.transform.position + rayLength * LHand.transform.forward;
                    }
                    Vector3 direction = destination - LHand.transform.position;
                    direction.Normalize();
                    GameObject projectile = Instantiate(rockPrefab, LHand.transform.position, LHand.transform.localRotation);
                    projectile.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
                    Destroy(projectile, 5);
                }
                break;
            case 10:
                //fire (flames)
                ResetLeft();
                FireL.SetActive(true);
                if (Input.GetButton("Oculus_CrossPlatform_PrimaryIndexTrigger"))
                {

                }
                break;
            case 50:
                //50 = water (lesser healing)
                ResetLeft();
                WaterL.SetActive(true);
                if (Input.GetButtonDown("Oculus_CrossPlatform_PrimaryIndexTrigger"))
                {

                }
                break;
            case 500:
                //500 = air (shield)
                ResetLeft();
                AirL.SetActive(true);
                if (Input.GetButton("Oculus_CrossPlatform_PrimaryIndexTrigger"))
                {

                }
                break;
            case 5000:
                //sword
                ResetLeft();
                //SwordL.SetActive(true);
                break;
        }

        //determines right hand spell
        switch (rightHand)
        {
            case 0:
                //empty

                break;
            case 1:
                //1 = earth (stun)
                ResetRight();
                EarthR.SetActive(true);
                if (Input.GetButtonDown("Oculus_CrossPlatform_PrimaryIndexTrigger") || Input.GetButtonDown("Fire1"))
                {
                    //shooting maybe
                    RaycastHit hit;
                    Vector3 destination;
                    if (Physics.Raycast(RHand.transform.position, RHand.transform.forward, out hit, 50))
                    {
                        destination = hit.point;
                    }
                    else
                    {
                        destination = RHand.transform.position + rayLength * RHand.transform.forward;
                    }
                    Vector3 direction = destination - RHand.transform.position;
                    direction.Normalize();
                    //rockPrefab.transform.eulerAngles = LHand.transform.eulerAngles;
                    Debug.Log(rockPrefab.transform.eulerAngles);
                    GameObject projectile = Instantiate(rockPrefab, RHand.transform.position, RHand.transform.localRotation);
                    //Quaternion.identity * Quaternion.Euler 
                    //LLHand.transform.eulerAngles.x, LHand.transform.eulerAngles.y, LHand.transform.eulerAngles.z));
                    //rockPrefab.transform.rotation = LHand.transform.rotation;

                    projectile.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
                    Destroy(projectile, 5);
                }
                break;
            case 10:
                //fire (flames)
                ResetRight();
                FireR.SetActive(true);
                GameObject jet;
                bool jetIn = false;
                float jetTime = 1.0f;
                float jetTimer = 0.0f;
                if (Input.GetButton("Fire1"))
                {
                    if (jetIn == false)
                    {
                        jet = Instantiate(firePrefab, RHand.transform.position, RHand.transform.localRotation);
                        jetIn = true;

                        Destroy(jet, 1);
                    }
                    jetTimer += Time.deltaTime;
                    if(jetTimer >= jetTime)
                    {
                        jetIn = false;
                        jetTimer = 0f;
                    }
                }

                break;
            case 50:
                //50 = water (lesser healing)
                ResetRight();
                WaterR.SetActive(true);
                break;
            case 500:
                //500 = air (shield)
                ResetRight();
                AirR.SetActive(true);
                break;
            case 5000:
                //sword
                ResetRight();
                //SwordR.SetActive(true);
                break;
        }

        //checking whether or not hands are in trigger
        if (LHand.GetComponent<OnHandCombos>().handIn == true)
        {
            if (leftHand > 0)
            {
                LHSave = leftHand;
            }
            if (rightHand > 0)
            {
                RHSave = rightHand;
            }
            combo = true;
        }
        else if (LHand.GetComponent<OnHandCombos>().handIn == false)
        {
            if (leftHand == 0)
            {
                leftHand = LHSave;
                LHSave = 0;
            }
            if (rightHand == 0)
            {
                rightHand = RHSave;
                RHSave = 0;
            }
            combo = false;
            FireballC.SetActive(false);
            MeteorC.SetActive(false);
            GrHealC.SetActive(false);
            CycloneC.SetActive(false);
            LavaC.SetActive(false);
            GravityC.SetActive(false);
            LifeC.SetActive(false);
            GeyserC.SetActive(false);
            LightningC.SetActive(false);
            IceC.SetActive(false);
        }

        //checking if combo spell is true
        if (combo == true)
        {
            leftHand = 0;
            rightHand = 0;

            //sets combo spells 
            switch (LHSave + RHSave)
            {
                case 2:
                    //meteor
                    ResetCombo();
                    MeteorC.SetActive(true);
                    break;
                case 11:
                    //lava
                    ResetCombo();
                    LavaC.SetActive(true);
                    break;
                case 20:
                    //fireball
                    ResetCombo();
                    FireballC.SetActive(true);
                    break;
                case 51:
                    //vines
                    ResetCombo();
                    LifeC.SetActive(true);
                    break;
                case 60:
                    //geyser
                    ResetCombo();
                    GeyserC.SetActive(true);
                    break;
                case 100:
                    //greater heal
                    ResetCombo();
                    GrHealC.SetActive(true);
                    break;
                case 501:
                    //gravity
                    ResetCombo();
                    GravityC.SetActive(true);
                    break;
                case 510:
                    //lightning
                    ResetCombo();
                    LightningC.SetActive(true);
                    if(LightningC == true /*Input.GetButtonDown(left or right trigger)  */)
                    {
                        //fire lightning from lightning script;
                    }
                    break;
                case 550:
                    //ice
                    ResetCombo();
                    IceC.SetActive(true);
                    if (Input.GetButtonDown("Fire1"))
                    {
                        GameObject projectile = Instantiate(icePrefab, player.transform.position - new Vector3(0, 0.7f, 0), player.transform.localRotation);
                    }
                    break;
                case 1000:
                    //cyclone
                    ResetCombo();
                    CycloneC.SetActive(true);
                    break;
                case 5001:
                    //earth and sword
                    ResetCombo();

                    break;
                case 5010:
                    //fire and sword
                    ResetCombo();
                    break;
                case 5050:
                    //water and sword
                    ResetCombo();

                    break;
                case 5500:
                    //air amd sword
                    ResetCombo();

                    break;
            }
        } 
    }

    
    //reset hands and combo
    public void ResetLeft()
    {
        FireL.SetActive(false);
        EarthL.SetActive(false);
        WaterL.SetActive(false);
        AirL.SetActive(false);
        //SwordL.SetActive(false);
    }
    public void ResetRight()
    {
        FireR.SetActive(false);
        EarthR.SetActive(false);
        WaterR.SetActive(false);
        AirR.SetActive(false);
        //SwordR.SetActive(false);
    }
    public void ResetCombo()
    {
        ResetLeft();
        ResetRight();
        FireballC.SetActive(false);
        MeteorC.SetActive(false);
        GrHealC.SetActive(false);
        CycloneC.SetActive(false);
        LavaC.SetActive(false);
        GravityC.SetActive(false);
        LifeC.SetActive(false);
        GeyserC.SetActive(false);
        LightningC.SetActive(false);
        IceC.SetActive(false);
    }

    //left hand
    public void FireLeft()
    {
        leftHand = 10;
        leftWheel.SetActive(false);
    }
    public void EarthLeft()
    {
        leftHand = 1;
        leftWheel.SetActive(false);
    }
    public void WaterLeft()
    {
        leftHand = 50;
        leftWheel.SetActive(false);
    }
    public void AirLeft()
    {
        leftHand = 500;
        leftWheel.SetActive(false);
    }
    public void SwordLeft()
    {
        if(rightHand == 5000)
        {
            rightHand = 0;
        }
        leftHand = 5000;
        leftWheel.SetActive(false);
    }

    //right hand
    public void FireRight()
    {
        rightHand = 10;
        rightWheel.SetActive(false);
    }
    public void EarthRight()
    {
        rightHand = 1;
        rightWheel.SetActive(false);
    }
    public void WaterRight()
    {
        rightHand = 50;
        rightWheel.SetActive(false);
    }
    public void AirRight()
    {
        rightHand = 500;
        rightWheel.SetActive(false);
    }
    public void SwordRight()
    {
        if (leftHand == 5000)
        {
            leftHand = 0;
        }
        rightHand = 5000;
        rightWheel.SetActive(false);
    }
}
//0 = empty
//1 = earth (stun) (I)
//2 = x2 earth (meteor) (I) (2)

//3 - 9

//10 = fire (flames) (C)
//11 = earth and fire (lava) (I) (2)

//12 - 19

//20 = x2 fire (fireball) (I) (2)

//21 - 49

//50 = water (lesser healing) (I)
//51 = earth and water (vines) (I) (2)

//52 - 59

//60 = fire and water (geyser) (I) (2)

//61 - 99

//100 = x2 water (greater heal) (C) (2)

//101 - 499


//500 = air (shield) (C)
//501 = earth and air (gravity) (I) (2)

//502 - 509

//510 = fire and air (lightning) (I) (2)

//511 - 549

//550 = water and air (ice) (I) (2)

//551 - 999

//1000 = x2 air (cyclone) (I) (2)

//1001 - 4999

//5000 = sword
//5001 = earth and sword (knockback) (2)

//5002 - 5009

//5010 = fire and sword (flame-tip) (2)

//5011 - 5049

//5050 = water and sword (drain/heal-hit) (2)

//5051 - 5499

//5500 = air and sword (rainged slash) (2)


//20 different values
//1 empty
//14 spell
//5 sword
//3 C
//11 I