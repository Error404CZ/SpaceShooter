using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //public GameObject Player;
    private PlayerMovment PlayerMovment;
    private Rigidbody rb;
    [SerializeField] private GameObject enemyMesh;
    [SerializeField] private GameObject enemyGunController;
    [SerializeField] private GameObject enemyExplosion;

    private Vector3 gravityForce;
    [SerializeField] private int forceIntUp = 200;
    [SerializeField] private int forceIntDown = 250;
    [SerializeField] private int speed=100;
    private Vector3 enemyForce;
    [SerializeField] private float time = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerMovment = Player.GetComponent<PlayerMovment>();
        rb = GetComponent<Rigidbody>();
        gravityForce.y = Random.Range(forceIntDown-1, forceIntUp);
        rb.AddForce(-gravityForce*Time.deltaTime*speed);
    }
    /*
    // Update is called once per frame
    void Update()
    {
        if (PlayerMovment.playerInput.x > rb.position.x)
        {
            enemyForce.x = 10f;
        }
        else
        {
            enemyForce.x = -10f;
        }
        rb.AddForce(enemyForce*speed*Time.deltaTime);
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Border")
        {
            StartCoroutine(enemyDestroy());
        }else if (other.tag == "Bolt")
        {
            StartCoroutine(enemyDestroy());
        }
        
    }
    
    IEnumerator enemyDestroy()
    {
        enemyMesh.SetActive(false);
        enemyGunController.SetActive(false);
        //Score.UpScore();
        enemyExplosion.SetActive(true);
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
