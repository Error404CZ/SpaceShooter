using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using  UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreTxtGame;
    [SerializeField] private TextMeshProUGUI scoreTxtGameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpScore()
    {
        //Debug.Log($"{score}");
        score = score + 1;
        scoreTxtGame.text = $"Score: {score}";
        scoreTxtGameOver.text = $"Final Score: {score}";
    }

    public void DownScore()
    {
        if (score > 0)
        {
            score = score - 1;
            scoreTxtGame.text = $"Score: {score}";
            scoreTxtGameOver.text = $"Final Score: {score}";
        }
    }
}
