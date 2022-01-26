using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody rb;

    private Vector3 playerInput;
    public float speed = 100f;
    private float xAxe;
    private float yAxe;
    private bool shoot;
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
        shoot = Input.GetKey(KeyCode.Space);
        
        rb.AddForce(playerInput*speed*Time.deltaTime);
    }
    
    public void playerShoot()
    {
        Debug.Log("Shoot");
    }
}
