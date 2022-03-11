using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Rigidbody PlayerRb;
    private Rigidbody rb;
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject enemyMesh;
    [SerializeField] private GameObject enemyGunController;
    [SerializeField] private GameObject enemyExplosion;

    private Vector3 gravityForce;
    [SerializeField] private int forceIntUp = 200;
    [SerializeField] private int forceIntDown = 250;
    [SerializeField] private int speed=100;
    private Vector3 enemyForce;
    [SerializeField] private float time = 0.5f;

    public Score Score;
    // Start is called before the first frame update
    void Start()
    {
        enemy.SetActive(true);
        rb = GetComponent<Rigidbody>();
        gravityForce.y = Random.Range(forceIntDown-1, forceIntUp);
        rb.AddForce(-gravityForce*Time.deltaTime*speed);
    }
    
    // Update is called once per frame
    void Update()
    {

        if (PlayerRb.position.x > rb.position.x)
        {
            enemyForce.x = 0.5f;
        }
        else
        {
            enemyForce.x = -0.5f;
        }
        rb.AddForce(enemyForce*speed*Time.deltaTime);
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Border")
        {
            Score.DownScore();
            Destroy(gameObject);
        }else if (other.tag == "Bolt")
        {
            Score.UpScore();
            StartCoroutine(enemyDestroy());
        }else if (other.tag == "DeathZone")
        {
            Destroy(gameObject);
        }
        
    }
    
    IEnumerator enemyDestroy()
    {
        enemyMesh.SetActive(false);
        enemyGunController.SetActive(false);
        enemyExplosion.SetActive(true);
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
