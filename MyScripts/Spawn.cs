using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Cherry;
    public Transform spawnLocation;

    float timer = 3;
    float currentTime = 0;
    bool timerOn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Cherry, spawnLocation.position, spawnLocation.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Spawner();
    }

    void Spawner()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //float x = Random.Range(0f, 10f);
            //float y = Random.Range(2f, -10f);
            //Instantiate(Cherry, new Vector3(x, y, 0), Quaternion.identity);
            timerOn = true;
            currentTime = timer;
        }
            if (timerOn)
            {
                currentTime = currentTime - Time.deltaTime;
                Debug.Log(currentTime);
                if (currentTime < 0)
                {
                    Vector3 position = new Vector3(Random.Range(-15, 20), Random.Range(1, 5), transform.position.z);
                    Instantiate(Cherry, position, transform.rotation);
                    timerOn = false;
                }
            }
        }
    }
