﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : MonoBehaviour
{
    public GameObject lHand;
    public GameObject rHand;

    public int mana = 1000;
    public int manaCap = 100;
    public int manaRegen = 5;
    public bool castingL = false;
    public bool castingR = false;
    public float regenTimer = 0.0f;
    public float regenTime = 1.0f;
    public bool canRegen = false;
    
    void Start()
    {
        lHand = GameObject.FindGameObjectWithTag("lHand");
        rHand = GameObject.FindGameObjectWithTag("rHand");
    }

    void Update()
    {
        castingL = lHand.GetComponent<NEWSpells>().casting;
        castingR = rHand.GetComponent<NEWSpells>().casting;
        canRegen = false;
        regenTimer += Time.deltaTime;
        if (regenTimer >= regenTime)
        {
            regenTimer = 0;
            canRegen = true;
        }
        if (castingL == false && canRegen == true && castingR == false)
        {
            mana += manaRegen;
        }
        if (mana > manaCap)
        {
            mana = manaCap;
        }
        if (mana < 0)
        {
            mana = 0;
        }
    }
}
