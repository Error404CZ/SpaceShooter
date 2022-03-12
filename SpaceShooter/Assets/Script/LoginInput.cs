using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginInput : MonoBehaviour
{
    [SerializeField] private TMP_InputField InputField;

    public ScoreData ScoreData;

    // Update is called once per frame
    void Update()
    {
        ScoreData.lastName = InputField.text;
    }
}
