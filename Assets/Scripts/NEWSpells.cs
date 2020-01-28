using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWSpells : MonoBehaviour
{
    //hands and big objects
    public GameObject player;
    public GameObject Hand;

    //base spells
    public GameObject Earth;
    public GameObject Fire;
    public GameObject Water;
    public GameObject Air;

    //list or array
    //public List<GameObject> spellsList;
    public GameObject[] spellsArray;

    //button assignments
    public OVRInput.Button menuOpen;
    public OVRInput.Button cast;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Hand = gameObject;
        spellsArray = GameObject.FindGameObjectsWithTag("spells");
        foreach(GameObject s in spellsArray)
        {
            s.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if stick button pressed then enable the 4 option menu (project settings input for stick button)
        if (OVRInput.GetDown(menuOpen))
        {
            
        }
        //inputs up and down to select spell (find in the project settings input)
    }

    //spell check list
    //
    // o all the variables are acounted for (gameObjects ints etc)
    // o all variables are assigned in the script
    // o pop up menus
    // o when you chose the icon the menu drops and the spell is enabled
    //
    //
    //2 menus with 4 options each
    //when you choose an option it assigns the appropriate hand with a #
    //depending on the number it will spawn one of 4 dormant effects
    //if the MAIN TRIGGER (the trigger associated with the hand) is pulled the dormant effect is replaced with the active effect and mana takes a toll
    //if the hands get within a certain proximity of one another then they merge (theyre values are stored then added and the appropriate added effect[dormant] is spawned in the hands)
    //if either trigger is pressed then the dual spell is cast and the mana is expended (if both triggers are pulled then <-- x2)
    //when the hands seperate it pulls the stored #s and assigns them
}
