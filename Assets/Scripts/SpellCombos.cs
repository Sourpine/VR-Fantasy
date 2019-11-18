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

    /*public GameObject FireballC;
    public GameObject MeteorC;
    public GameObject GrHealC;
    public GameObject CycloneC;

    public GameObject LavaC;
    public GameObject GravityC;
    public GameObject LifeC;
    public GameObject GeyserC;
    public GameObject LightningC;
    public GameObject IceC;*/

    // Start is called before the first frame update
    void Start()
    {
        leftHand = 0;
        rightHand = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(leftHand);
        //Debug.Log(rightHand);
        
        //how to set as combo
        if(rIn == true && lIn == true)
        {
            combo = true;
        }

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
        if(rightWheel.activeSelf == true || leftWheel.activeSelf == true)
        {
            player.GetComponent<OVRPlayerController>().enabled = false;
        }
        else if (rightWheel.activeSelf == false && leftWheel.activeSelf == false)
        {
            player.GetComponent<OVRPlayerController>().enabled = true;
        }
        switch (leftHand)
        {
            case 0:
                //empty
                
                break;
            case 1:
                //1 = earth (stun)
                EarthL.SetActive(true);
                break;
            case 10:
                //fire (flames)
                FireL.SetActive(true);
                break;
            case 50:
                //50 = water (lesser healing)
                WaterL.SetActive(true);
                break;
            case 500:
                //500 = air (shield)
                AirL.SetActive(true);
                break;
            case 5000:
                //sword
                
                break;
        }
        switch (rightHand)
        {
            case 0:
                //empty

                break;
            case 1:
                //1 = earth (stun)
                EarthR.SetActive(true);
                break;
            case 10:
                //fire (flames)
                FireR.SetActive(true);
                break;
            case 50:
                //50 = water (lesser healing)
                WaterR.SetActive(true);
                break;
            case 500:
                //500 = air (shield)
                AirR.SetActive(true);
                break;
            case 5000:
                //sword

                break;
        }
        if (combo == true)
        {
            switch (leftHand + rightHand)
            {
                case 2:
                    //meteor

                    break;
                case 11:
                    //lava

                    break;
                case 20:
                    //fireball

                    break;
                case 51:
                    //vines

                    break;
                case 60:
                    //geyser

                    break;
                case 100:
                    //greater heal

                    break;
                case 501:
                    //gravity

                    break;
                case 510:
                    //lightning

                    break;
                case 550:
                    //ice

                    break;
                case 1000:
                    //cyclone

                    break;
                case 5001:
                    //earth and sword

                    break;
                case 5010:
                    //fire and sword

                    break;
                case 5050:
                    //water and sword

                    break;
                case 5500:
                    //air amd sword

                    break;
            }
        }
    }

    public void ResetLeft()
    {
        FireL.SetActive(false);
        EarthL.SetActive(false);
        WaterL.SetActive(false);
        AirL.SetActive(false);
    }
    public void ResetRight()
    {
        FireR.SetActive(false);
        EarthR.SetActive(false);
        WaterR.SetActive(false);
        AirR.SetActive(false);
    }
    public void ResetCombo()
    {

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
        leftHand = 5000;
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