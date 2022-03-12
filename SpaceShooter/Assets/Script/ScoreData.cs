using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData : MonoBehaviour
{
    [HideInInspector] public string lastName;
    [HideInInspector] public int lastSocre;
    [HideInInspector] public string bestName;
    [HideInInspector] public int bestScore;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log($"{lastName} {lastSocre} {bestName} {bestScore}");
    }
}
