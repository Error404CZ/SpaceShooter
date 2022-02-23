using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject enemyBolt;
    [HideInInspector] public bool isShootableEnemy = true;
    private float shootRate;
    private AudioSource AudioSource;
    [SerializeField] private AudioClip audioClipBoom;    
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        AudioSource.clip=audioClipBoom;
        StartCoroutine(enemyShoot());
    }

    IEnumerator enemyShoot()
    {
        while (isShootableEnemy)
        {
            shootRate = Random.Range(1, 5);
            yield return new WaitForSeconds(shootRate);
            GameObject newInstance = Instantiate(enemyBolt);
            newInstance.transform.position = transform.position;
            AudioSource.Play();
        }
    }
}
