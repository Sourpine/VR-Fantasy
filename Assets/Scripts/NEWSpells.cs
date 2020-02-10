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
    public float bulletSpeed;
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
        //NOT IMPLEMENTED
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
        mana = player.GetComponent<Mana>().mana;
        manaTime += Time.deltaTime;
        if(manaTimer >= manaTime)
        {

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
            //NOT IMPLEMENTED
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
            case 1:
                ClearHand();
                //passive (this one's temp)
                Earth.SetActive(true);
                if (OVRInput.GetDown(cast) && mana >= ECostI)
                {
                    player.GetComponent<Mana>().mana -= ECostI;
                    Earth.SetActive(false);
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
                    projectile.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
                    Earth.SetActive(true);
                    Destroy(projectile, 5);

                }
                break;
            case 10:
                ClearHand();
                //passive (this one's temp)
                Fire.SetActive(true);
                //enable the firePrefab game object then disable if let go or if mana if gone
                if (OVRInput.GetDown(cast) && mana >= FCostI)
                {
                    player.GetComponent<Mana>().mana -= FCostI;
                    Fire.SetActive(false);
                    FirePrefab.SetActive(true);
                }
                if (OVRInput.Get(cast) && mana >= FCostC)
                {
                    player.GetComponent<Mana>().mana -= FCostC;
                    FirePrefab.SetActive(true);
                }
                if (OVRInput.GetUp(cast))
                {
                    FirePrefab.SetActive(false);
                    Fire.SetActive(true);
                }
                break;
            case 50:
                ClearHand();
                //passive (this one's temp)
                Water.SetActive(true);
                //
                if (OVRInput.GetDown(cast))
                {
                    //instantiate the water spell (might follow player position)
                }
                break;
            case 500:
                ClearHand();

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
    //work in progress o when you click a trigger it fires the spell
    // o when you put the hands close enough together it makes a combo
    //
    //2 menus with 4 options each
    //when you choose an option it assigns the appropriate hand with a #
    //depending on the number it will spawn one of 4 dormant effects
    //if the MAIN TRIGGER (the trigger associated with the hand) is pulled the dormant effect is replaced with the active effect and mana takes a toll
    //if the hands get within a certain proximity of one another then they merge (theyre values are stored then added and the appropriate added effect[dormant] is spawned in the hands)
    //if either trigger is pressed then the dual spell is cast and the mana is expended (if both triggers are pulled then <-- x2)
    //when the hands seperate it pulls the stored #s and assigns them
}
