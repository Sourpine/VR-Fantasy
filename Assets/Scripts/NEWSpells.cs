using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWSpells : MonoBehaviour
{
    //hands and big objects
    public GameObject player;
    public GameObject Hand;
    public GameObject OtherHand;

    //base spells
    private GameObject Earth;
    private GameObject Fire;
    private GameObject Water;
    private GameObject Air;

    //combo spells
    private GameObject Earthx2;
    private GameObject Firex2;
    private GameObject Waterx2;
    private GameObject Airx2;
    private GameObject EarthFire;
    private GameObject EarthWater;
    private GameObject EarthAir;
    private GameObject FireWater;
    private GameObject FireAir;
    private GameObject WaterAir;

    //menus and event systems
    public GameObject Menu;
    public GameObject EventSystem;

    //button assignments
    public OVRInput.Button menuOpen;
    public OVRInput.Button cast;

    //button values
    public int value = 0;
    public int valueSave = 0;

    //prefabs
    public GameObject EarthPrefab;
    public GameObject FirePrefab;
    public GameObject WaterPrefab;
    public GameObject AirPrefab;
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


    // Start is called before the first frame update
    void Start()
    {
        //setting the variables based off tag and name
        player = GameObject.FindGameObjectWithTag("Player");
        Hand = gameObject;
        if(Hand.tag == "lHand")
        {
            OtherHand = GameObject.FindGameObjectWithTag("rHand");
            Earth = GameObject.Find("Earth(L)");
            Fire = GameObject.Find("Fire(L)");
            Water = GameObject.Find("Water(L)");
            Air = GameObject.Find("Air(L)");
            Menu = GameObject.Find("leftWheel");
            EventSystem = GameObject.Find("EventSystem(L)");
        }
        if(Hand.tag == "rHand")
        {
            OtherHand = GameObject.FindGameObjectWithTag("lHand");
            Earth = GameObject.Find("Earth(R)");
            Fire = GameObject.Find("Fire(R)");
            Water = GameObject.Find("Water(R)");
            Air = GameObject.Find("Air(R)");
            Menu = GameObject.Find("rightWheel");
            EventSystem = GameObject.Find("EventSystem(R)");
        }
        Earthx2 = GameObject.Find("Earthx2");
        Firex2 = GameObject.Find("Firex2");
        Waterx2 = GameObject.Find("Waterx2");
        Airx2 = GameObject.Find("Airx2");
        EarthFire = GameObject.Find("EarhtFire");
        EarthWater = GameObject.Find("EarhtWater");
        EarthAir = GameObject.Find("EarhtAir");
        FireWater = GameObject.Find("FireWater");
        FireAir = GameObject.Find("FireAir");
        WaterAir = GameObject.Find("WaterAir");

        //disabling the game objects after they're set
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

        Earth.SetActive(false);
        Fire.SetActive(false);
        Water.SetActive(false);
        Air.SetActive(false);
        Menu.SetActive(false);
        EventSystem.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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
                if (OVRInput.GetDown(cast))
                {
                    //instantiate the rock
                }
                break;
            case 10:
                ClearHand();
                //passive (this one's temp)
                Fire.SetActive(true);
                //enable the firePrefab game object then disable if let go or if mana if gone
                if (OVRInput.GetDown(cast))
                {
                    FirePrefab.SetActive(true);
                }
                if (OVRInput.GetUp(cast))
                {
                    FirePrefab.SetActive(false);
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
    // o pop up menus
    // o when you chose the icon the menu drops and the spell is enabled
    // o when you click a trigger it fires the spell
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
