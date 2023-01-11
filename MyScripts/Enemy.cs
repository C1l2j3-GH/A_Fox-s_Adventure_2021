using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int healthPoint = 100;

    //public GameObject dyingEffect;

    public void TakeDamage(int damage)
    {
        healthPoint -= damage;
    
    if(healthPoint <=0)
        {
            Die();
        }
    }
    
    void Die()
    {
        //Instantiate(dyingEffect, transform.position, Quaternion.identity);
  
        Destroy(gameObject);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
