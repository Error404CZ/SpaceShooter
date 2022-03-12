using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public SaveData SaveDataS;
    public ScoreData ScoreDataS;
    private string fileData = "saveData.txt";
    private string fileScore = "scoreData.txt";

    public void SaveData()
    {
        string jsonData = JsonUtility.ToJson(SaveDataS);
        //Debug.Log(json);
        WriteToFile(fileData, jsonData);
        Debug.Log("SaveData");
    }
    public void SaveScore()
    {
        string jsonData = JsonUtility.ToJson(ScoreDataS);
        //Debug.Log(json);
        WriteToFile(fileScore, jsonData);
        Debug.Log("SaveScore");
    }

    public void LoadData()
    {
        string jsonData = ReadFromFile(fileData);
        JsonUtility.FromJsonOverwrite(jsonData, SaveDataS);
        Debug.Log("LoadData");
    }
    public void LoadScore()
    {
        string jsonScore = ReadFromFile(fileScore);
        JsonUtility.FromJsonOverwrite(jsonScore, ScoreDataS);
        Debug.Log("LoadScore");
    }

    private void WriteToFile(string fileName, string jsonData)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(jsonData);
        }
    }

    private string ReadFromFile(string fileName)
    {
        string path = GetFilePath(fileName);
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string jsonData = reader.ReadToEnd();
                return jsonData;
            }
        }else
        {
            Debug.LogWarning("!File not found!");
        }

        return "";
    }

    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
}
