using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonGame : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;

    [SerializeField] private GameObject exitScreen;
    // Start is called before the first frame update
    void Start()
    {
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
