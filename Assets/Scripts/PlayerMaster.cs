using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaster : MonoBehaviour
{
    public delegate void GeneralEventhandler();

    public delegate void PlayerHealthEventHandler(int healthChange);
    public event PlayerHealthEventHandler EventPlayerHealthDeduction;
    public event PlayerHealthEventHandler EventPlayerHealthIncrease;

    public void CallEventPlayerHealthDeduction(int dmg)
    {
        if(EventPlayerHealthDeduction != null)
        {
            EventPlayerHealthDeduction(dmg);
        }
    }

    public void CallEventPlayerHealthIncrease(int increase)
    {
        if(EventPlayerHealthIncrease != null)
        {
            EventPlayerHealthIncrease(increase);
        }
    }

}
