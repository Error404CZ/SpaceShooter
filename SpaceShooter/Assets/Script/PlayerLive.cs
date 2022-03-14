using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLive : MonoBehaviour
{
    [SerializeField] private GameObject playerAll;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject explosion;
    [SerializeField] private float time = 2f;

    public Score Score;

    public CollisionManagerScript CollisionManagerScript;

    private void OnTriggerEnter(Collider other)
    {
        CollisionManagerScript.Player(playerAll, other, player, explosion, time);
    }
}
