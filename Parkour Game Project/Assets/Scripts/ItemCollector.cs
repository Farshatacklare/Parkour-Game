using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int apple = 0;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            apple++;
            Debug.Log("Apple: " + apple);
        }


    }
    
    
    
     
}
