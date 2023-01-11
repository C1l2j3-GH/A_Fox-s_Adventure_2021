using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;
    public int enemyDamage = 30;

    public InGameUI hpBar;

    // Start is called before the first frame update
    public void Start()
    {
        currentHP = maxHP;
        hpBar.SetMaxHealth(maxHP);
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            currentHP -= enemyDamage;
            hpBar.SetHealth(currentHP);
        }



        //if (currentHP <= 0)
        //{
        //    Time.timeScale = 0f;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
