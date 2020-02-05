using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : MonoBehaviour
{
    public GameObject lHand;
    public GameObject rHand;

    public int mana = 100;
    public int manaCap = 100;
    public int manaRegen = 5;
    public bool castingL = false;
    public bool castingR = false;
    
    void Start()
    {
        lHand = GameObject.FindGameObjectWithTag("lHand");
        rHand = GameObject.FindGameObjectWithTag("rHand");
    }

    void Update()
    {
        castingL = lHand.GetComponent<NEWSpells>().casting;
        castingR = rHand.GetComponent<NEWSpells>().casting;
        if(castingL == false || castingR == false)
        {
            mana += manaRegen;
        }
        if (mana > manaCap)
        {
            mana = manaCap;
        }
    }
}
