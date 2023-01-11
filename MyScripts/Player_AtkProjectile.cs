using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AtkProjectile : MonoBehaviour
{
    //SpriteRenderer renderer;
    //AudioSource audioSource;
//public AudioClip explosioNNN;
    //float timer = 1.5f;
    //public GameObject explosion;
    public GameObject fireBall;

    public Transform firePoint;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        //renderer = GetComponent<SpriteRenderer>();
        //audioSource.clip = bombExp;
        //Invoke("explodeEffect", 1.5f);
        //audioSource.PlayDelayed(1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //if(timer > 0)
        //{
        //    timer = timer - Time.deltaTime;
        //}

        //if(timer <= 0)
        //{
        //    renderer.enabled = false;
        //}
    
    if(Input.GetKeyDown(KeyCode.J))
        {
            Shoot();
        }
    }

    //public void rangedAttack()
    //{
    //    Rigidbody2D projectile;
    //    projectile = Instantiate(projectile, fireport.tranform.position, transform.rotation);
    //    //bomb.velocity = newVector3(5, 5, 0);

    //    //int myDirection;

    //    //if(facingRight)
    //    //{
    //    //      myDirection = 1;
    //    //}
    //    //else
    //    //{
    //    //      myDirection = -1;
    //    //}

    //    int run = facingRight ? 1 : -1;

    //    projectile.AddForce(new Vector2(run * 2, 5), ForceMode2D.Impulse);
    //    Destroy(projectile.gameObject, 3.1f);
    //}
    
    
    //public void explodeEffect()
    //{
    //    GameObject explode;
    //    explode = Instantiate(explosion, transform.position, transform.rotation);
    //    Destroy(explosion, 1f);
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.CompareTag("enemy"))
    //    {
    //        CancelInvoke();
    //        audioSource.Stop();
    //        timer = 0;
    //        explodeEffect();
    //        audioSource.Play();
    //    }
    //            }

    //For shooting ranged attacks
    void Shoot()
    {
        Instantiate(fireBall, firePoint.position, firePoint.rotation);
    }

}
