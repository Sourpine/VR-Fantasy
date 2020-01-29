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
        //if stick button pressed then enable the 4 option menu (project settings input for stick button)
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


        //tests
        /*if (Input.GetButtonDown("Fire1"))
        {
            OtherHand.GetComponent<NEWSpells>().Menu.SetActive(true);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            OtherHand.GetComponent<NEWSpells>().Menu.SetActive(false);
        }*/
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
