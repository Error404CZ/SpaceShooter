using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private int speed=-100;
    
    private Vector3 force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        force.y = 500;
        rb.AddForce(force * Time.deltaTime*speed);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Border")
        {
            Destroy(gameObject);
        }else if (other.tag == "Asteroid")
        {
            Destroy(gameObject);
        }
        
    }
}
