using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject shotbolt;
    
    private bool isShootable = true;
    public float shootRate = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (isShootable == true)
            {
                StartCoroutine(shoot());
            }
        }
    }

    IEnumerator shoot()
    {
        isShootable = false;
        GameObject newInstance = Instantiate(shotbolt);
        newInstance.transform.position = transform.position;
        yield return new WaitForSeconds(shootRate);
        isShootable = true;
    }
}
