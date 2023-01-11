using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Object Collected");
            //PlayerMovement PMove = Player.GetComponent<PlayerMovement>();
            //PMove.CollectedObj_Num++;
           
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().CollectedObj_Num++;
            
            Destroy(this.gameObject);
        
        }
    }
}
