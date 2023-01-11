using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    //public Button item1;
    //public Button item2;
    //public Text item1_Text;
    //public Text item2_Text;
    public Text cherryNumDisplay;
    public Text hpCountDisplay;

    public Slider hpBarSlider;
    public int cherryNum;
    public int hpCount;


    public CharacterController charController;

    //public string[] myNarration;
    //public Text narrationText;
    //public int currentText = 0;
    //public GameObject narrateBox;
    
    public Text timeCounter;
    public float remainingTime = 120;
    
    
    
    // Start is called before the first frame update
    private void Start()
    {
        //item1.enabled = false;
        //item1.image.enabled = false;
        //item1_Text.enabled = false;

        //item2.interactable = false;
        //item2.image.enabled = false;
        //item2_Text.enabled = false;

        timeCounter.text = remainingTime.ToString();

        //myNarrations();
    }

    // Update is called once per frame
    private void Update()
    {
        if(remainingTime > 0)
        {
            remainingTime = remainingTime - Time.deltaTime;
        }

        timeCounter.text = remainingTime.ToString("0.00");
        //timeCounter.text = remainingTime.ToString("F3");

        //if (charController.gameObject.GetComponent<CharacterController2D>().chestOpen == true)
        //{
        //    item1.enabled = true;
        //    item1.image.enabled = true;
        //    item1_Text.enabled = true;

        //    item2.interactable = true;
        //    item2.image.enabled = true;
        //    item2_Text.enabled = true;
        //}

        //if(Input.GetMouseButtonDown(0))
        //    {
        //        myNarrations();
        //    }
        ////if()
        ////{
        ////    item_MainDisplayNum++;
        ////}

        objectCount();
        currentHPCount();

    }

    public void objectCount()
    {
        //GetComponent<PlayerMovement>().CollectedObj_Num++;
        cherryNum = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().CollectedObj_Num;
        //cherryNum = GetComponent<PlayerMovement>().CollectedObj_Num;
        cherryNumDisplay.text = cherryNum.ToString();
    }

    public void SetMaxHealth(int health)
    {
        hpBarSlider.maxValue = health;
        hpBarSlider.value = health;
    }

    public void SetHealth(int health)
    {
        hpBarSlider.value = health;
    }

    public void currentHPCount()
    {
        hpCount = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>().currentHP;

        if (hpCount <= 0)
        {
            hpCount = 0;
        }

        hpCountDisplay.text = hpCount.ToString();
    
    }



}
