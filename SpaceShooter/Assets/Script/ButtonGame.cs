using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonGame : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;

    [SerializeField] private GameObject exitScreen;

    public DataManager DataManager;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.Load();
        gameOverScreen.SetActive(false);
    }

    public void tryAgainClick()
    {
        SceneManager.LoadScene("Main");
    }

    public void backButtonClick()
    {
        SceneManager.LoadScene("Lobby");
    }
}
