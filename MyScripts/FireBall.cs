using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed = 10f;

    public int damage = 20;

    public Rigidbody2D rb2D;

    //public GameObject hitEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2D.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        //hitInfo.
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }

       //Instantiate(hitEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
