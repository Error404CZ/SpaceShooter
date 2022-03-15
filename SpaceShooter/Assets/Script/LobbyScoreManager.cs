using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LobbyScoreManager : MonoBehaviour
{
    public DataManager DataManager;
    public ScoreData ScoreData;

    [SerializeField] private TextMeshProUGUI ls;
    [SerializeField] private TextMeshProUGUI bs;
    
    // Start is called before the first frame update
    void Start()
    {
        DataManager.LoadScore();
        ls.text = $"LS: {ScoreData.lastName}:  {ScoreData.lastScore}";
        bs.text = $"BS: {ScoreData.bestName}:  {ScoreData.bestScore}";
    }
}
