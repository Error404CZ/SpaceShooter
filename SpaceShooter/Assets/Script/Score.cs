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

    [SerializeField] private TextMeshProUGUI ls;
    [SerializeField] private TextMeshProUGUI bs;
    //[SerializeField] private TextMeshProUGUI scoreTxtGameOver;

    public ScoreData ScoreData;
    public DataManager DataManager;
    
    // Start is called before the first frame update
    void Start()
    {
        DataManager.LoadScore();
        ScoreData.yourScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpScore()
    {
        //Debug.Log($"{score}");
        ScoreData.yourScore = ScoreData.yourScore + 1;
        scoreTxtGame.text = $"Score: {ScoreData.yourScore}";
    }

    public void DownScore()
    {
        if (ScoreData.yourScore > 0)
        {
            ScoreData.yourScore = ScoreData.yourScore - 1;
            scoreTxtGame.text = $"Score: {ScoreData.yourScore}";
        }
    }

    public void FinalScore()
    {
        ScoreData.lastScore = ScoreData.yourScore;
        ScoreData.lastName = ScoreData.loggedName;
        if (ScoreData.lastScore > ScoreData.bestScore)
        {
            ScoreData.bestName = ScoreData.loggedName;
            ScoreData.bestScore = ScoreData.lastScore;
        }
        ls.text = $"LS: {ScoreData.lastName} - {ScoreData.lastScore}";
        bs.text = $"BS: {ScoreData.bestName} - {ScoreData.bestScore}";
        DataManager.SaveScore();
    }
}
