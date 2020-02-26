using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoMoveScript : MonoBehaviour
{
    public iTween.EaseType movementEaseType = iTween.EaseType.easeInOutSine;
    public float movementRadius = 30;
    public float movementSpeed = 0.5f;

    private Vector3 originalPosition;

    

    void Start()
    {
        originalPosition = transform.position;
        StartCoroutine(Movement());
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    IEnumerator Movement()
    {
        //Choose Location

    }






}
