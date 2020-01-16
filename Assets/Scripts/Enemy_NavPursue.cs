﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_NavPursue : MonoBehaviour
{
    private EnemyMaster enemyMaster;
    private NavMeshAgent navMeshAgent;
    private float checkRate;
    private float nextCheck;
    private NavMeshAgent myNavMeshAgent;

    void OnEnable()
    {
        SetInitialRefrences();
        enemyMaster.EventEnemyDie += DisableThis;

    }

    void OnDisable()
    {
        enemyMaster.EventEnemyDie -= DisableThis;

    }

    void Update()
    {
        if (Time.time > nextCheck)
        {
            nextCheck = Time.time + checkRate;
            TryToChaseTarget();
        }
    }

    void SetInitialRefrences()
    {
        enemyMaster = GetComponent<EnemyMaster>();
        if(GetComponent<UnityEngine.AI.NavMeshAgent>()!= null)
        {
            myNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }
        checkRate = Random.Range(0.1f, 0.2f);
    }

    void TryToChaseTarget()
    {
        if(enemyMaster.myTarget != null && !enemyMaster.isNavPaused)
        {
            myNavMeshAgent.SetDestination(enemyMaster.myTarget.position);

            if(myNavMeshAgent.remainingDistance>myNavMeshAgent.stoppingDistance)
            {
                enemyMaster.CallEventEnemyWalking();
                enemyMaster.isOnRoute = true;
                
            }

        }
    }

    void DisableThis()
    {
        if(myNavMeshAgent != null)
        {
            myNavMeshAgent.enabled = false;
        }

        this.enabled = false;
    }




}
