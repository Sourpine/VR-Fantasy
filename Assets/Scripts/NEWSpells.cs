using System.Collections;
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
    public int valueCombo = 0;
    public bool combined = false;

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
    //endpoint if spell hits nothing
    public GameObject endpoint;

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
    //initial
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
    //channeling


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
        //endpoint
        endpoint = GameObject.Find("endpoint");

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

        if (combined == true)
        {
            Menu.SetActive(false);
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
        if (OVRInput.GetDown(menuOpen) && Menu.activeSelf == false && combined == false)
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



        //  B   A   S   E

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
                    if (Physics.Raycast(Hand.transform.position, Hand.transform.forward, out hit, 50, 13))
                    {
                        destination = hit.point;
                    }
                    else
                    {
                        destination = Hand.transform.position + rayLength * Hand.transform.forward;
                    }
                    Vector3 direction = destination - Hand.transform.position;
                    direction.Normalize();
                    GameObject projectile = Instantiate(EarthPrefab, Hand.transform.position, Hand.transform.rotation);
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
                    GameObject projectile = Instantiate(WaterPrefab, Hand.transform.position, Hand.transform.rotation);
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
                if(OVRInput.GetUp(cast) && WaterLow.activeSelf == false)
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



        //  C   O   M   B   O   S

        //saves and assigns the combo value
        if (combined == true)
        {
            switch (valueSave + OtherHand.GetComponent<NEWSpells>().valueSave)
            {
                //x2 combos

                // E A R T H X 2 (meteor)     since evry spell is so individual it will take heavy tweaking once given acess to the prefabs
                case 2:
                    ComboClear();
                    Earthx2.SetActive(true);
                    //when mana goes above the threshold then dissable the low
                    if(mana >= E2CostI)
                    {
                        Earthx2Low.SetActive(false);
                        if (Earthx2Prefab.activeSelf == false)
                        {
                            Earthx2.SetActive(true);
                        }
                    }
                    if (OVRInput.GetDown(cast) && mana >= E2CostI)
                    {
                        player.GetComponent<Mana>().mana -= E2CostI;
                        casting = true;
                        Earthx2.SetActive(false);
                        RaycastHit hit;
                        Vector3 destination;
                        if (Physics.Raycast(Hand.transform.position, Hand.transform.forward, out hit, 50, 13))
                        {
                            destination = hit.point;
                        }
                        else
                        {
                            destination = endpoint.transform.position;
                        }
                        GameObject projectile = Instantiate(Earthx2Prefab, destination, endpoint.transform.rotation);
                        projectile.SetActive(true);
                        Earthx2.SetActive(true);
                        Destroy(projectile, 5);
                    }
                    //not enough mana low enabled
                    else if (mana < E2CostI)
                    {
                        Earthx2Prefab.SetActive(false);
                        Earthx2.SetActive(false);
                        Earthx2Low.SetActive(true);
                        casting = false;
                    }
                    //when button released and passive re-enabled
                    if (OVRInput.GetUp(cast) && Earthx2Low.activeSelf == false)
                    {
                        Earthx2Prefab.SetActive(false);
                        Earthx2.SetActive(true);
                        casting = false;
                    }
                    break;

                // F I R E X 2 (fireball)
                case 20:
                    ComboClear();
                    Firex2.SetActive(true);
                    //when mana goes above the threshhold then dissable low
                    if (mana >= F2CostI)
                    {
                        Firex2Low.SetActive(false);
                        if (Firex2Prefab.activeSelf == false)
                        {
                            Firex2.SetActive(true);
                        }
                    }
                    //when button pressed spell enabled (enough mana)
                    if (OVRInput.GetDown(cast) && mana >= F2CostI)
                    {
                        player.GetComponent<Mana>().mana -= F2CostI;
                        RaycastHit hit;
                        Vector3 destination;
                        if (Physics.Raycast(Hand.transform.position, Hand.transform.forward, out hit, 50, 13))
                        {
                            destination = hit.point;
                        }
                        else
                        {
                            destination = Hand.transform.position + rayLength * Hand.transform.forward;
                        }
                        Vector3 direction = destination - Hand.transform.position;
                        direction.Normalize();
                        GameObject projectile = Instantiate(Firex2Prefab, Hand.transform.position, Hand.transform.rotation);
                        projectile.SetActive(true);
                        projectile.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
                        Firex2.SetActive(true);
                        Destroy(projectile, 5);
                    }
                    //not enough mana low enabled
                    else if (mana < W2CostI)
                    {
                        Firex2Prefab.SetActive(false);
                        Firex2.SetActive(false);
                        Firex2Low.SetActive(true);
                        casting = false;
                    }
                    //when button up the passive re-enabled
                    if (OVRInput.GetUp(cast) && Firex2Low.activeSelf == false)
                    {
                        Firex2Prefab.SetActive(false);
                        Firex2.SetActive(true);
                        casting = false;
                    }
                    break;

                // W A T E R X 2 (greater heal)
                case 100:
                    ComboClear();
                    Waterx2.SetActive(true);
                    //when mana goes above the threshhold then dissable low
                    if (mana >= W2CostI)
                    {
                        Waterx2Low.SetActive(false);
                        if (Waterx2Prefab.activeSelf == false)
                        {
                            Waterx2.SetActive(true);
                        }
                    }
                    //when button pressed spell enabled (enough mana)
                    if (OVRInput.GetDown(cast) && mana >= W2CostI)
                    {
                        player.GetComponent<Mana>().mana -= W2CostI;
                        casting = true;
                        Waterx2.SetActive(false);
                        GameObject projectile = Instantiate(Waterx2Prefab, Hand.transform.position, endpoint.transform.rotation);
                        projectile.SetActive(true);
                        Waterx2.SetActive(true);
                        Destroy(projectile, 5);
                    }
                    //not enough mana low enabled
                    else if (mana < W2CostI)
                    {
                        Waterx2Prefab.SetActive(false);
                        Waterx2.SetActive(false);
                        Waterx2Low.SetActive(true);
                        casting = false;
                    }
                    //when button up the passive re-enabled
                    if (OVRInput.GetUp(cast) && Waterx2Low.activeSelf == false)
                    {
                        Waterx2Prefab.SetActive(false);
                        Waterx2.SetActive(true);
                        casting = false;
                    }
                    break;

                // A I R X 2 (cyclone)
                case 1000:
                    ComboClear();
                    //determine
                    break;

                //combos involving 2 different bases
                // E A R T H F I R E (lava)
                case 11:
                    ComboClear();
                    EarthFire.SetActive(true);
                    //when mana goes above the threshold then dissable the low
                    if (mana >= EFCostI)
                    {
                        EarthFireLow.SetActive(false);
                        if (EarthFirePrefab.activeSelf == false)
                        {
                            EarthFire.SetActive(true);
                        }
                    }
                    if (OVRInput.GetDown(cast) && mana >= EFCostI)
                    {
                        player.GetComponent<Mana>().mana -= EFCostI;
                        casting = true;
                        EarthFire.SetActive(false);
                        RaycastHit hit;
                        Vector3 destination;
                        if (Physics.Raycast(Hand.transform.position, Hand.transform.forward, out hit, 50, 13))
                        {
                            destination = hit.point;
                        }
                        else
                        {
                            destination = endpoint.transform.position;
                        }
                        GameObject projectile = Instantiate(EarthFirePrefab, destination, endpoint.transform.rotation);
                        projectile.SetActive(true);
                        EarthFire.SetActive(true);
                        Destroy(projectile, 5);
                    }
                    //not enough mana low enabled
                    else if (mana < EFCostI)
                    {
                        EarthFirePrefab.SetActive(false);
                        EarthFire.SetActive(false);
                        EarthFireLow.SetActive(true);
                        casting = false;
                    }
                    //when button released and passive re-enabled
                    if (OVRInput.GetUp(cast) && EarthFireLow.activeSelf == false)
                    {
                        EarthFirePrefab.SetActive(false);
                        EarthFire.SetActive(true);
                        casting = false;
                    }
                    break;

                // E A R T H W A T E R (vines)
                case 51:
                    ComboClear();
                    EarthWater.SetActive(true);
                    //when mana goes above the threshhold then dissable low
                    if (mana >= EWCostI)
                    {
                        EarthWaterLow.SetActive(false);
                        if (EarthWaterPrefab.activeSelf == false)
                        {
                            EarthWater.SetActive(true);
                        }
                    }
                    //when button pressed spell enabled (enough mana)
                    if (OVRInput.GetDown(cast) && mana >= EWCostI)
                    {
                        player.GetComponent<Mana>().mana -= EWCostI;
                        casting = true;
                        EarthWater.SetActive(false);
                        RaycastHit hit;
                        Vector3 destination;
                        if (Physics.Raycast(Hand.transform.position, Hand.transform.forward, out hit, 50, 13))
                        {
                            destination = hit.point;
                        }
                        else
                        {
                            destination = endpoint.transform.position;
                        }
                        GameObject projectile = Instantiate(EarthWaterPrefab, destination, endpoint.transform.rotation);
                        projectile.SetActive(true);
                        EarthWater.SetActive(true);
                        Destroy(projectile, 5);
                    }
                    //not enough mana low enabled
                    else if (mana < EWCostI)
                    {
                        EarthWaterPrefab.SetActive(false);
                        EarthWater.SetActive(false);
                        EarthWaterLow.SetActive(true);
                        casting = false;
                    }
                    //when button up the passive re-enabled
                    if (OVRInput.GetUp(cast) && EarthWaterLow.activeSelf == false)
                    {
                        EarthWaterPrefab.SetActive(false);
                        EarthWater.SetActive(true);
                        casting = false;
                    }
                    break;

                // E A R T H A I R (gravity)
                case 501:
                    ComboClear();
                    EarthAir.SetActive(true);
                    //determine
                    break;

                // F I R E W A T E R (geyser)
                case 60:
                    ComboClear();
                    FireWater.SetActive(true);
                    //when mana goes above the threshhold then dissable low
                    if (mana >= FWCostI)
                    {
                        FireWaterLow.SetActive(false);
                        if (FireWaterPrefab.activeSelf == false)
                        {
                            FireWater.SetActive(true);
                        }
                    }
                    //when button pressed spell enabled (enough mana)
                    if (OVRInput.GetDown(cast) && mana >= FWCostI)
                    {
                        player.GetComponent<Mana>().mana -= FWCostI;
                        casting = true;
                        FireWater.SetActive(false);
                        RaycastHit hit;
                        Vector3 destination;
                        if (Physics.Raycast(Hand.transform.position, Hand.transform.forward, out hit, 50, 13))
                        {
                            destination = hit.point;
                        }
                        else
                        {
                            destination = endpoint.transform.position;
                        }
                        GameObject projectile = Instantiate(FireWaterPrefab, destination, endpoint.transform.rotation);
                        projectile.SetActive(true);
                        FireWater.SetActive(true);
                        Destroy(projectile, 5);
                    }
                    //not enough mana low enabled
                    else if (mana < FWCostI)
                    {
                        FireWaterPrefab.SetActive(false);
                        FireWater.SetActive(false);
                        FireWaterLow.SetActive(true);
                        casting = false;
                    }
                    //when button up the passive re-enabled
                    if (OVRInput.GetUp(cast) && FireWaterLow.activeSelf == false)
                    {
                        FireWaterPrefab.SetActive(false);
                        FireWater.SetActive(true);
                        casting = false;
                    }
                    break;

                // F I R E A I R (lightning)
                case 510:
                    ComboClear();
                    FireAir.SetActive(true);
                    //YIKES
                    break;

                // W A T E R A I R (ice)
                case 550:
                    ComboClear();
                    WaterAir.SetActive(true);
                    //when mana goes above the threshhold then dissable low
                    if (mana >= WACostI)
                    {
                        WaterAir.SetActive(false);
                        if (WaterAirPrefab.activeSelf == false)
                        {
                            WaterAir.SetActive(true);
                        }
                    }
                    //when button pressed spell enabled (enough mana)
                    if (OVRInput.GetDown(cast) && mana >= WACostI)
                    {
                        player.GetComponent<Mana>().mana -= WACostI;
                        casting = true;
                        WaterAir.SetActive(false);
                        GameObject projectile = Instantiate(WaterAirPrefab, Hand.transform.position, endpoint.transform.rotation);
                        projectile.SetActive(true);
                        WaterAir.SetActive(true);
                        Destroy(projectile, 5);
                    }
                    //not enough mana low enabled
                    else if (mana < WACostI)
                    {
                        WaterAirPrefab.SetActive(false);
                        WaterAir.SetActive(false);
                        WaterAirLow.SetActive(true);
                        casting = false;
                    }
                    //when button up the passive re-enabled
                    if (OVRInput.GetUp(cast) && WaterAirLow.activeSelf == false)
                    {
                        WaterAirPrefab.SetActive(false);
                        WaterAir.SetActive(true);
                        casting = false;
                    }
                    break;
            }

        }

        //Debug.Log("READ ME! " + (value + OtherHand.GetComponent<NEWSpells>().value));
        //Debug.Log("ALSO READ ME! " + (valueSave + OtherHand.GetComponent<NEWSpells>().valueSave));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(Hand.tag == "lHand" && combined == false)
        {
            if (other.name == "ComboTrigger")
            {
                valueSave = value;
                OtherHand.GetComponent<NEWSpells>().valueSave = OtherHand.GetComponent<NEWSpells>().value;
                value = 0;
                OtherHand.GetComponent<NEWSpells>().value = 0;
                combined = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (Hand.tag == "lHand" && combined == true)
        {
            if (other.name == "ComboTrigger")
            {
                value = valueSave;
                OtherHand.GetComponent<NEWSpells>().value = OtherHand.GetComponent<NEWSpells>().valueSave;
                valueSave = 0;
                OtherHand.GetComponent<NEWSpells>().valueSave = 0;
                //Debug.Log("LEFT " + value);
                //Debug.Log("RIGHT " + OtherHand.GetComponent<NEWSpells>().value);
                ComboClear();
                combined = false;
            }
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
        Earth.SetActive(false); //1
        Fire.SetActive(false); //10
        Water.SetActive(false); //50
        Air.SetActive(false); //500

        EarthLow.SetActive(false);
        FireLow.SetActive(false);
        WaterLow.SetActive(false);
        AirLow.SetActive(false);

        EarthPrefab.SetActive(false);
        //FirePrefab.SetActive(false);
        WaterPrefab.SetActive(false);
        //AirPrefab.SetActive(false);
    }
    public void ComboClear()
    {
        Earthx2.SetActive(false); //2
        Firex2.SetActive(false); //20
        Waterx2.SetActive(false); //100
        Airx2.SetActive(false); //1000
        EarthFire.SetActive(false); //11
        EarthWater.SetActive(false); //51
        EarthAir.SetActive(false); //501
        FireWater.SetActive(false); //60
        FireAir.SetActive(false); //510
        WaterAir.SetActive(false); //550

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


    /*
    meteor
    fireball
    greater heal
    cyclone
    lava
    vines
    gravity
    geyser
    lightning
    ice
    */

    //lava, vines, and geyser all copy meteor
}
