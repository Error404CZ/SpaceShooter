using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManagerScript : MonoBehaviour
{
    public Score Score;

    [SerializeField] private GameObject asteroidController;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject scoreScreen;
    [SerializeField] private GameObject deathZone;
    public void Bolt(GameObject object1, Collider object2)
    {
        if (object2.tag == "Border")
        {
            Destroy(object1);
        }else if (object2.tag == "Enemy")
        {
            Destroy(object1);
        }else if (object2.tag == "Asteroid")
        {
            Destroy(object1);
        }
    }

    public void EnemyBolt(GameObject object1, Collider object2)
    {
        if (object2.tag == "Border")
        {
            Destroy(object1);
        }else if (object2.tag == "Asteroid")
        {
            Destroy(object1);
        }
    }

    public void Asteroid(GameObject object1, Collider object2, GameObject asteridMesh, GameObject explosion, float time)
    {
        if (object2.tag == "Bolt")
        {
            Score.UpScore();
            StartCoroutine(asteroidDestroy(asteridMesh, explosion, time, object1));
        }else if (object2.tag == "EnemyBolt")
        {
            Score.DownScore();
            StartCoroutine(asteroidDestroy(asteridMesh, explosion, time, object1));
        }else if (object2.tag == "Border")
        {
            Score.DownScore();
            Destroy(object1);
        }else if (object2.tag == "DeathZone")
        {
            Destroy(object1);
        }
    }
    
    IEnumerator asteroidDestroy(GameObject asteridMesh, GameObject explosion, float time, GameObject object1)
    {
        asteridMesh.SetActive(false);
        explosion.SetActive(true);
        yield return new WaitForSeconds(time);
        Destroy(object1);
    }

    public void Enemy(GameObject object1, Collider object2, GameObject enemyMesh, GameObject enemyGunController, GameObject enemyExplosion, float time)
    {
        if (object2.tag == "EnemyBorder")
        {
            Score.DownScore();
            StartCoroutine(enemyDestroy(enemyMesh, enemyGunController, enemyExplosion, time, object1));
        }else if (object2.tag == "Bolt")
        {
            Score.UpScore();
            StartCoroutine(enemyDestroy(enemyMesh, enemyGunController, enemyExplosion, time, object1));
        }else if (object2.tag == "DeathZone")
        {
            Destroy(object1);
        }else if (object2.tag == "Border")
        {
            Destroy(object1);
        }
    }
    
    IEnumerator enemyDestroy(GameObject enemyMesh, GameObject enemyGunController, GameObject enemyExplosion, float time, GameObject object1)
    {
        enemyMesh.SetActive(false);
        enemyGunController.SetActive(false);
        enemyExplosion.SetActive(true);
        yield return new WaitForSeconds(time);
        Destroy(object1);
    }

    public void Player(GameObject object1, Collider object2, GameObject player, GameObject explosion, float time)
    {
        if (object2.tag == "Asteroid")
        {
            StartCoroutine(death(player, explosion, time, object1));
        }else if (object2.tag == "Enemy")
        {
            StartCoroutine(death(player, explosion, time, object1));
        }else if (object2.tag == "EnemyBolt")
        {
            StartCoroutine(death(player, explosion, time, object1));
        }
    }
    IEnumerator death(GameObject player, GameObject explosion, float time, GameObject playerAll)
    {
        asteroidController.SetActive(false);
        player.SetActive(false);
        explosion.SetActive(true);
        Score.FinalScore();
        yield return new WaitForSeconds(time);
        scoreScreen.SetActive(false);
        gameOverScreen.SetActive(true);
        playerAll.SetActive(false);
        deathZone.SetActive(true);
    }
}
