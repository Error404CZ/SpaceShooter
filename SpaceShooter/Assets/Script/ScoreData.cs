using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData : MonoBehaviour
{
    [HideInInspector] public string lastName;
    [HideInInspector] public int lastScore;
    [HideInInspector] public string bestName;
    [HideInInspector] public int bestScore;
    [HideInInspector] public string loggedName;
    [HideInInspector] public int yourScore;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log($"{lastName} {lastScore} {bestName} {bestScore} {loggedName} {yourScore}");
    }
}
