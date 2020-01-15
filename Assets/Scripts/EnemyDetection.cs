using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    private EnemyMaster enemyMaster;
    private Transform myTransform;
    public Transform head;
    public LayerMask playerlayer;
    public LayerMask sightLayer;
    private float checkRate;
    private float nextCheck;
    private float detectRadius = 80;
    private RaycastHit hit;

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
        CarryOutDetection();
        

    }

    void SetInitialRefrences()
    {
        enemyMaster = GetComponent<EnemyMaster>();
        myTransform = transform;

        /*if (head = null)
        {
            head = myTransform;
        }*/

        checkRate = Random.Range(0.8f, 1.2f);
    }

    void CarryOutDetection()
    {
        if (Time.time > nextCheck)
        {
            nextCheck = Time.time + checkRate;

            Collider[] colliders = Physics.OverlapSphere(myTransform.position, detectRadius, playerlayer);

            if (colliders.Length > 0)
            {
                foreach (Collider potentialTargetCollider in colliders)
                {
                    if (potentialTargetCollider.CompareTag(GameManager_References._playerTag))
                    {
                        if (CanPotentialTargetBeSeen(potentialTargetCollider.transform))
                        {
                            break;
                        }
                    }

                }
            }

            else
            {
                enemyMaster.CallEventEnemyLostTarget();
            }

              
            }
        }

        bool CanPotentialTargetBeSeen(Transform potentialTarget)
        {
            if (Physics.Linecast(head.position, potentialTarget.position, out hit, sightLayer))
            {
                if (hit.transform == potentialTarget)
                {
                    enemyMaster.CallEventEnemySetNavTarget(potentialTarget);
                    return true;
                }
                else
                {
                    enemyMaster.CallEventEnemyLostTarget();
                    return false;
                }
            }
            else
            {
                enemyMaster.CallEventEnemyLostTarget();
                return false;
            }
        }

    void DisableThis()
    {
        this.enabled = false;

    }
}

    
 

