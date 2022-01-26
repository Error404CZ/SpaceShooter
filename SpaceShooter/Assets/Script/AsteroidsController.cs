using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class AsteroidsController : MonoBehaviour
{

    private Rigidbody rb;
    private int speed=100;

    private Vector3 vectorRotation;

    private Vector3 force;

    public int forceIntUp = 250;
    public int forceIntDown = 300;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        vectorRotation.x = Random.Range(-500, 500);
        vectorRotation.y = Random.Range(-500, 500);
        vectorRotation.z = Random.Range(-500, 500);
        force.y = Random.Range(forceIntDown-1, forceIntUp);
        rb.AddTorque(vectorRotation * Time.deltaTime*speed);
        rb.AddForce(-force * Time.deltaTime*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Border")
        {
            Destroy(gameObject);
        }
        
    }
}
