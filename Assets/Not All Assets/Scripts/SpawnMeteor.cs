using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    public GameObject vfx;
    public Transform startPoint;
    public Transform endPoint;

    public float meteorWaitTime = 1.0f;
    public float meteorWaitTimer = 0f;
    public bool canFire = false;
    public bool hasFired = false;

    void Start()
    {
        /*var startPos = startPoint.position;
        GameObject objVFX = Instantiate(vfx, startPos, Quaternion.identity) as GameObject;

        var endPos = endPoint.position;

        RotateTo(objVFX, endPos);*/
    }

    void Update()
    {
        meteorWaitTimer += Time.deltaTime;
        if(meteorWaitTimer >= meteorWaitTime)
        {
            canFire = true;
        }

        if (canFire == true && hasFired == false)
        {
            var startPos = startPoint.position;
            GameObject objVFX = Instantiate(vfx, startPos, Quaternion.identity) as GameObject;

            var endPos = endPoint.position;

            RotateTo(objVFX, endPos);
        }
    }

    void RotateTo (GameObject obj, Vector3 destination)
    {
        var direction = destination - obj.transform.position;
        var rotaion = Quaternion.LookRotation(direction);
        obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotaion, 1);
    }

    
}
