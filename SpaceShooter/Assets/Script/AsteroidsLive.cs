using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsLive : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bolt")
        {
            Destroy(gameObject);
        }
        
    }
}
