﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWSpells : MonoBehaviour
{
    
    //VERY IMPORTANT!!!
    //the spell game objects are currently using temp assets
    //need to change and recenter by end of project
    
    //hands and big objects
    public GameObject player;
    public GameObject Hand;
    public GameObject OtherHand;

    //mana
    public int mana;
    public bool casting = false;
    public float manaTimer = 0;
    public float manaTime = 1.0f;
    public bool manaCost = false;

    //base spells
    //passive w/ mana
    public GameObject Earth;
    public GameObject Fire;
    public GameObject Water;
    public GameObject Air;

    //combo spells
    //passive w/ mana
    public GameObject Earthx2;
    public GameObject Firex2;
    public GameObject Waterx2;
    public GameObject Airx2;
    public GameObject EarthFire;
    public GameObject EarthWater;
    public GameObject EarthAir;
    public GameObject FireWater;
    public GameObject FireAir;
    public GameObject WaterAir;

    //menus and event systems
    public GameObject Menu;
    public GameObject EventSystem;

    //button assignments
    public OVRInput.Button menuOpen;
    public OVRInput.Button cast;

    //button values
    public int value = 0;
    public int valueSave = 0;

    //base spells
    //passive no mana
    public GameObject EarthLow;
    public GameObject FireLow;
    public GameObject WaterLow;
    public GameObject AirLow;

    //combo spells
    //passive no mana
    public GameObject Earthx2Low;
    public GameObject Firex2Low;
    public GameObject Waterx2Low;
    public GameObject Airx2Low;
    public GameObject EarthFireLow;
    public GameObject EarthWaterLow;
    public GameObject EarthAirLow;
    public GameObject FireWaterLow;
    public GameObject FireAirLow;
    public GameObject WaterAirLow;

    //prefabs
    //active
    //some of these may be redundant
    public GameObject EarthPrefab;
    public GameObject FirePrefab;
    public GameObject WaterPrefab;
    public GameObject AirPrefab;

    //prefabs combo
    //active
    //some of these may be redundant
    public GameObject Earthx2Prefab;
    public GameObject Firex2Prefab;
    public GameObject Waterx2Prefab;
    public GameObject Airx2Prefab;
    public GameObject EarthFirePrefab;
    public GameObject EarthWaterPrefab;
    public GameObject EarthAirPrefab;
    public GameObject FireWaterPrefab;
    public GameObject FireAirPrefab;
    public GameObject WaterAirPrefab;

    //bullet variables
    public float bulletSpeed = 10;
    public float rayLength = 50.0f;

    //disable timers and bool
    public float disTimer = 0.0f;
    public float disTime = 0.1f;
    public bool dis;

    //mana cost variables (base spells)
    //initial
    public int ECostI = 10;
    public int FCostI = 10;
    public int WCostI = 10;
    public int ACostI = 10;
    //channeling
    public int FCostC = 2;
    public int ACostC = 2;

    //mana cost variable (combo spells)
    public int E2CostI = 10;
    public int F2CostI = 10;
    public int W2CostI = 10;
    public int A2CostI = 10;
    public int EFCostI = 10;
    public int EWCostI = 10;
    public int EACostI = 10;
    public int FWCostI = 10;
    public int FACostI = 10;
    public int WACostI = 10;


    void Start()
    {
        //setting the variables based off tag and name
        player = GameObject.FindGameObjectWithTag("Player");
        Hand = gameObject;
        //LEFT HAND
        if (Hand.tag == "lHand")
        {
            //right hand
            OtherHand = GameObject.FindGameObjectWithTag("rHand");

            //passive low mana left spells
            EarthLow = GameObject.Find("EarthLow(L)");
            FireLow = GameObject.Find("FireLow(L)");
            WaterLow = GameObject.Find("WaterLow(L)");
            AirLow = GameObject.Find("AirLow(L)");
            
            //passive w/ mana left spells
            Earth = GameObject.Find("Earth(L)");
            Fire = GameObject.Find("Fire(L)");
            Water = GameObject.Find("Water(L)");
            Air = GameObject.Find("Air(L)");

            //active left spells
            //NOT IMPLEMENTED
            //the spells which require Instantiation are likely refrenced elsewhere
            EarthPrefab = GameObject.Find("EarthPrefab(L)");
            FirePrefab = GameObject.Find("FirePrefab(L)");
            WaterPrefab = GameObject.Find("WaterPrefab(L)");
            AirPrefab = GameObject.Find("AirPrefab(L)");

            //left ui
            Menu = GameObject.Find("leftWheel");
            EventSystem = GameObject.Find("EventSystem(L)");
        }
        //RIGHT HAND
        if(Hand.tag == "rHand")
        {
            //left hand
            OtherHand = GameObject.FindGameObjectWithTag("lHand");

            //passive low mana right spells
            EarthLow = GameObject.Find("EarthLow(R)");
            FireLow = GameObject.Find("FireLow(R)");
            WaterLow = GameObject.Find("WaterLow(R)");
            AirLow = GameObject.Find("AirLow(R)");

            //passive w/ mana right spells
            Earth = GameObject.Find("Earth(R)");
            Fire = GameObject.Find("Fire(R)");
            Water = GameObject.Find("Water(R)");
            Air = GameObject.Find("Air(R)");

            //active right spells
            //NOT IMPLEMENTED
            //the spells which require Instantiation are likely refrenced elsewhere
            EarthPrefab = GameObject.Find("EarthPrefab(R)");
            FirePrefab = GameObject.Find("FirePrefab(R)");
            WaterPrefab = GameObject.Find("WaterPrefab(R)");
            AirPrefab = GameObject.Find("AirPrefab(R)");

            //right ui
            Menu = GameObject.Find("rightWheel");
            EventSystem = GameObject.Find("EventSystem(R)");
        }

        //passive low mana combo spells
        Earthx2Low = GameObject.Find("Earthx2Low");
        Firex2Low = GameObject.Find("Firex2Low");
        Waterx2Low = GameObject.Find("Waterx2Low");
        Airx2Low = GameObject.Find("Airx2Low");
        EarthFireLow = GameObject.Find("EarthFireLow");
        EarthWaterLow = GameObject.Find("EarthWaterLow");
        EarthAirLow = GameObject.Find("EarthAirLow");
        FireWaterLow = GameObject.Find("FireWaterLow");
        FireAirLow = GameObject.Find("FireAirLow");
        WaterAirLow = GameObject.Find("WaterAirLow");

        //passive w/ mana combo spells
        Earthx2 = GameObject.Find("Earthx2");
        Firex2 = GameObject.Find("Firex2");
        Waterx2 = GameObject.Find("Waterx2");
        Airx2 = GameObject.Find("Airx2");
        EarthFire = GameObject.Find("EarthFire");
        EarthWater = GameObject.Find("EarthWater");
        EarthAir = GameObject.Find("EarthAir");
        FireWater = GameObject.Find("FireWater");
        FireAir = GameObject.Find("FireAir");
        WaterAir = GameObject.Find("WaterAir");

        //active combo spells
        Earthx2Prefab = GameObject.Find("Earthx2Prefab");
        Firex2Prefab = GameObject.Find("Firex2Prefab");
        Waterx2Prefab = GameObject.Find("Waterx2Prefab");
        Airx2Prefab = GameObject.Find("Airx2Prefab");
        EarthFirePrefab = GameObject.Find("EarthFirePrefab");
        EarthWaterPrefab = GameObject.Find("EarthWaterPrefab");
        EarthAirPrefab = GameObject.Find("EarthAirPrefab");
        FireWaterPrefab = GameObject.Find("FireWaterPrefab");
        FireAirPrefab = GameObject.Find("FireAirPrefab");
        WaterAirPrefab = GameObject.Find("WaterAirPrefab");

        //the spells which require Instantiation are likely refrenced elsewhere

        //disabling the game objects after they're set

        //disabling w/ mana base spells
        Earth.SetActive(false);
        Fire.SetActive(false);
        Water.SetActive(false);
        Air.SetActive(false);

        //disabling low mana base spells
        EarthLow.SetActive(false);
        FireLow.SetActive(false);
        WaterLow.SetActive(false);
        AirLow.SetActive(false);

        //disabling active base spells
        //Not all implemented
        EarthPrefab.SetActive(false);
        FirePrefab.SetActive(false);
        WaterPrefab.SetActive(false);
        AirPrefab.SetActive(false);

        //disabling ui
        Menu.SetActive(false);
        EventSystem.SetActive(false);
    }

    void Update()
    {
        manaCost = false;
        mana = player.GetComponent<Mana>().mana;
        manaTimer += Time.deltaTime;
        if(manaTimer >= manaTime)
        {
            manaCost = true;
            manaTimer = 0;
        }
        
        //disables variables here to avoid error
        if(dis == false)
        {
            disTimer += Time.deltaTime;
        }
        if (disTimer >= disTime)
        {
            dis = true;
            disTimer = 0f;

            //disabling w/ mana combos
            Earthx2.SetActive(false);
            Firex2.SetActive(false);
            Waterx2.SetActive(false);
            Airx2.SetActive(false);
            EarthFire.SetActive(false);
            EarthWater.SetActive(false);
            EarthAir.SetActive(false);
            FireWater.SetActive(false);
            FireAir.SetActive(false);
            WaterAir.SetActive(false);

            //disabling low mana combos
            Earthx2Low.SetActive(false);
            Firex2Low.SetActive(false);
            Waterx2Low.SetActive(false);
            Airx2Low.SetActive(false);
            EarthFireLow.SetActive(false);
            EarthWaterLow.SetActive(false);
            EarthAirLow.SetActive(false);
            FireWaterLow.SetActive(false);
            FireAirLow.SetActive(false);
            WaterAirLow.SetActive(false);

            //diabling active combos
            Earthx2Prefab.SetActive(false);
            Firex2Prefab.SetActive(false);
            Waterx2Prefab.SetActive(false);
            Airx2Prefab.SetActive(false);
            EarthFirePrefab.SetActive(false);
            EarthWaterPrefab.SetActive(false);
            EarthAirPrefab.SetActive(false);
            FireWaterPrefab.SetActive(false);
            FireAirPrefab.SetActive(false);
            WaterAirPrefab.SetActive(false);
        }
        
        //deals with menu appearing and setting the right event system
        if (OVRInput.GetDown(menuOpen) && Menu.activeSelf == false)
        {
            Menu.SetActive(true);
            EventSystem.SetActive(true);
            OtherHand.GetComponent<NEWSpells>().Menu.SetActive(false);
            OtherHand.GetComponent<NEWSpells>().EventSystem.SetActive(false);
        }
        else if(OVRInput.GetDown(menuOpen) && Menu.activeSelf == true)
        {
            Menu.SetActive(false);
            EventSystem.SetActive(false);
        }
        if(Menu.activeSelf == true)
        {
            player.GetComponent<OVRPlayerController>().enabled = false;
        }
        if(Menu.activeSelf == false)
        {
            player.GetComponent<OVRPlayerController>().enabled = true;
        }        

        //inputs up and down to select spell (find in the project settings input)
        //depending on the value this sets the correct object to active
        switch (value)
        {
            case 0:
                ClearHand();
                break;

            //  E   A   R   T   H
            case 1:
                ClearHand();
                Earth.SetActive(true);
                //when mana is high enough low is replaced
                if (mana >= ECostI)
                {
                    EarthLow.SetActive(false);
                    Earth.SetActive(true);
                }
                //button pressed and mana high enough
                if (OVRInput.GetDown(cast) && mana >= ECostI)
                {
                    player.GetComponent<Mana>().mana -= ECostI;
                    //Earth.SetActive(false);
                    RaycastHit hit;
                    Vector3 destination;
                    if (Physics.Raycast(Hand.transform.position, Hand.transform.forward, out hit, 50))
                    {
                        destination = hit.point;
                    }
                    else
                    {
                        destination = Hand.transform.position + rayLength * Hand.transform.forward;
                    }
                    Vector3 direction = destination - Hand.transform.position;
                    direction.Normalize();
                    GameObject projectile = Instantiate(EarthPrefab, Hand.transform.position, Hand.transform.localRotation);
                    projectile.SetActive(true);
                    projectile.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
                    Earth.SetActive(true);
                    Destroy(projectile, 5);
                }
                //button pressed but mana low
                else if(mana < ECostI)
                {
                    Earth.SetActive(false);
                    EarthPrefab.SetActive(false);
                    EarthLow.SetActive(true);
                }
                //this is irrelevant for the non channeling spells
                /*if(OVRInput.GetUp(cast) && EarthLow.activeSelf == false)
                {
                    EarthPrefab.SetActive(false);
                    Earth.SetActive(true);
                }*/
                break;

            //  F   I   R   E
            case 10:
                ClearHand();
                //when mana grows above treshhold then dissable low
                if(mana >= FCostI)
                {
                    FireLow.SetActive(false);
                    if (FirePrefab.activeSelf == false)
                    {
                        Fire.SetActive(true);
                    }
                }
                //enable the firePrefab if mana correct and button pressed
                if (OVRInput.GetDown(cast) && mana >= FCostI)
                {
                    player.GetComponent<Mana>().mana -= FCostI;
                    casting = true;
                    Fire.SetActive(false);
                    FirePrefab.SetActive(true);
                }
                //not enough mana enables low prefab
                else if (mana < FCostI)
                {
                    FirePrefab.SetActive(false);
                    Fire.SetActive(false);
                    FireLow.SetActive(true);
                    casting = false;
                }
                //continues to enable prefab and take mana
                if (OVRInput.Get(cast) && mana >= FCostC && manaCost == true && FireLow.activeSelf == false)
                {
                    player.GetComponent<Mana>().mana -= FCostC;
                    FirePrefab.SetActive(true);
                }
                //not enough mana enables low prefab
                else if (mana < FCostC)
                {
                    FirePrefab.SetActive(false);
                    Fire.SetActive(false);
                    FireLow.SetActive(true);
                    casting = false;
                }
                //when cast comes up dissables spell
                if (OVRInput.GetUp(cast) && FireLow.activeSelf == false)
                {
                    FirePrefab.SetActive(false);
                    Fire.SetActive(true);
                    casting = false;
                }
                break;

            //  W   A   T   E   R
            case 50:
                ClearHand();
                Water.SetActive(true);
                //when mana goes above the threshhold then dissable low
                if (mana >= WCostI)
                {
                    WaterLow.SetActive(false);
                    if(WaterPrefab.activeSelf == false)
                    {
                        Water.SetActive(true);
                    }
                }
                //when button pressed spell enabled (enough mana)
                if (OVRInput.GetDown(cast) && mana >= WCostI)
                {
                    player.GetComponent<Mana>().mana -= WCostI;
                    casting = true;
                    Water.SetActive(false);
                    GameObject projectile = Instantiate(WaterPrefab, Hand.transform.position, Hand.transform.localRotation);
                    projectile.SetActive(true);
                    Water.SetActive(true);
                    Destroy(projectile, 5);
                }
                //not enough mana low enabled
                else if (mana < WCostI)
                {
                    WaterPrefab.SetActive(false);
                    Water.SetActive(false);
                    WaterLow.SetActive(true);
                    casting = false;
                }
                //when button up the passive re-enabled
                if(OVRInput.GetUp(cast) && FireLow.activeSelf == false)
                {
                    WaterPrefab.SetActive(false);
                    Water.SetActive(true);
                    casting = false;
                }
                break;

            //  A   I   R
            case 500:
                ClearHand();
                //mana regened
                if (mana >= ACostI)
                {
                    AirLow.SetActive(false);
                    //spell not being cast
                    if (AirPrefab.activeSelf == false)
                    {
                        Air.SetActive(true);
                    }
                }
                //casting w/ enough mana
                if (OVRInput.GetDown(cast) && mana >= ACostI)
                {
                    player.GetComponent<Mana>().mana -= ACostI;
                    casting = true;
                    Air.SetActive(false);
                    AirPrefab.SetActive(true);
                }
                //mana too low (initial)
                else if (mana < ACostI)
                {
                    AirPrefab.SetActive(false);
                    Air.SetActive(false);
                    AirLow.SetActive(true);
                    casting = false;
                }
                //channeling w/ enough mana
                if (OVRInput.Get(cast) && mana >= ACostC && manaCost == true && AirLow.activeSelf == false)
                {
                    player.GetComponent<Mana>().mana -= ACostC;
                    AirPrefab.SetActive(true);
                }
                //mana too low (channeling)
                else if(mana < ACostC)
                {
                    AirPrefab.SetActive(false);
                    Air.SetActive(false);
                    AirLow.SetActive(true);
                    casting = false;
                }
                //when button released dissables
                if (OVRInput.GetUp(cast) && AirLow.activeSelf == false)
                {
                    AirPrefab.SetActive(false);
                    Air.SetActive(true);
                }
                break;
        }
    }
    //button input functions
    public void EarthFunction()
    {
        value = 1;
        Menu.SetActive(false);
    }
    public void FireFunction()
    {
        value = 10;
        Menu.SetActive(false);
    }
    public void WaterFunction()
    {
        value = 50;
        Menu.SetActive(false);
    }
    public void AirFunction()
    {
        value = 500;
        Menu.SetActive(false);
    }
    public void EmptyFunction()
    {
        value = 0;
        Menu.SetActive(false);
    }

    //these functions are for the switches
    public void ClearHand()
    {
        Earth.SetActive(false);
        Fire.SetActive(false);
        Water.SetActive(false);
        Air.SetActive(false);

        EarthLow.SetActive(false);
        FireLow.SetActive(false);
        WaterLow.SetActive(false);
        AirLow.SetActive(false);

        EarthPrefab.SetActive(false);
        //FirePrefab.SetActive(false);
        WaterPrefab.SetActive(false);
        //AirPrefab.SetActive(false);
    }
    public void OutOfManaClear()
    {
        //earth
        FirePrefab.SetActive(false);
        //water
        //air
        //probably combos too
    }

    //spell check list
    //
    //done o all the variables are acounted for (gameObjects ints etc)
    //done o all variables are assigned in the script
    //done o pop up menus
    //done o when you chose the icon the menu drops and the spell is enabled
    //done o when you click a trigger it fires the spell
    // o when you put the hands close enough together it makes a combo
    // o all the above for combos
    //
    //2 menus with 4 options each
    //when you choose an option it assigns the appropriate hand with a #
    //depending on the number it will spawn one of 4 dormant effects
    //if the MAIN TRIGGER (the trigger associated with the hand) is pulled the dormant effect is replaced with the active effect and mana takes a toll
    //if the hands get within a certain proximity of one another then they merge (theyre values are stored then added and the appropriate added effect[dormant] is spawned in the hands)
    //if either trigger is pressed then the dual spell is cast and the mana is expended (if both triggers are pulled then <-- x2)
    //when the hands seperate it pulls the stored #s and assigns them
}
