using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 10;

    private Animator EnemyController;
    // Start is called before the first frame update
    void Start()
    {
        EnemyController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "spell")
        {
            health--;

            EnemyController.SetTrigger("Struck");








        }
    }
    
        
    
}
