using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public SaveData data;
    private string file = "save.txt";

    public void Save()
    {
        string json = JsonUtility.ToJson(data);
        //Debug.Log(json);
        WriteToFile(file, json);
        Debug.Log("Save");
    }

    public void Load()
    {
        //data = new SaveData();
        string json = ReadFromFile(file);
        JsonUtility.FromJsonOverwrite(json, data);
        Debug.Log("Load");
    }

    private void WriteToFile(string fileName, string json)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
    }

    private string ReadFromFile(string fileName)
    {
        string path = GetFilePath(fileName);
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
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
