using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AsteroidsLive : MonoBehaviour
{
    [SerializeField] private GameObject me;
    
    
    [SerializeField] private float time = 2f;
    [SerializeField] private GameObject asteridMesh;
    [SerializeField] private GameObject explosion;
    
    public CollisionManagerScript CollisionManagerScript;
    private void OnTriggerEnter(Collider other)
    {
        CollisionManagerScript.Asteroid(me, other, asteridMesh, explosion, time);
    }
}
