using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody rb;

    public Vector3 playerInput;
    public float speed = 100f;
    public float gravity=5;

    void Start()
    {
        rb = Player.GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0f, -gravity,0f);
    }

    // Update is called once per frame
    void Update()
    {
        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.y = Input.GetAxisRaw("Vertical");
        
        
        rb.AddForce(playerInput*speed*Time.deltaTime);
    }
}
