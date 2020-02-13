using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private EnemyMaster enemyMaster;
    private Animator myAnimator;

    void OnEnable()
    {
        SetInitalReferences();
        enemyMaster.EventEnemyDie += DisableAnimator;
        enemyMaster.EventEnemyWalking += SetAnimationToWalk;
        enemyMaster.EventEnemyReachedNavTarget += SetAnimationToIdle;
        enemyMaster.EventEnemyAttack += SetAnimationToAttack;
        enemyMaster.EventEnemyDeductHealth += SetAnimationToStruck;

    }

    void OnDisable()
    {
        enemyMaster.EventEnemyDie -= DisableAnimator;
        enemyMaster.EventEnemyWalking -= SetAnimationToWalk;
        enemyMaster.EventEnemyReachedNavTarget -= SetAnimationToIdle;
        enemyMaster.EventEnemyAttack -= SetAnimationToAttack;
        enemyMaster.EventEnemyDeductHealth -= SetAnimationToStruck;
    }

    void SetInitalReferences()
    {
        enemyMaster = GetComponent<EnemyMaster>();

        if(GetComponent<Animator>()!=null)
        {
            myAnimator = GetComponent<Animator>();
        }
    }

    void SetAnimationToWalk()
    {
        if (myAnimator != null)
        {
            if(myAnimator.enabled)
            {
                myAnimator.SetBool("isPursuing", true);
                myAnimator.SetBool("Bruh", false);
            }
        }
    }

    void SetAnimationToIdle()
    {
        if (myAnimator != null)
        {
            if (myAnimator.enabled)
            {
                myAnimator.SetBool("isPursuing", false);
                //myAnimator.SetBool("Attack 0", false);
            }
        }
    }

    void SetAnimationToAttack()
    {
        if (myAnimator != null)
        {
            if (myAnimator.enabled)
            {
                myAnimator.SetBool("Bruh", true);
            }
        }
    }

    void SetAnimationToStruck(int dummy)
    {
        if (myAnimator != null)
        {
            if (myAnimator.enabled)
            {
                myAnimator.SetTrigger("Struck");
                myAnimator.SetBool("Bruh", false);
            }
        }
    }

    void SetAnimationToDie()
    {
        if (myAnimator != null)
        {
            if (myAnimator.enabled)
            {
                myAnimator.SetTrigger("Die");
                myAnimator.SetBool("Bruh", false);
            }
        }
    }

    void DisableAnimator()
    {
        if(myAnimator != null)
        {
            myAnimator.enabled = false;

        }
    }
}
