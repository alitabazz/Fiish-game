using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private string gameSceneName;
    [SerializeField] private string gameSceneName2;

    // Start is called before the first frame update
    private void Start()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
        creditsButton.onClick.AddListener(Credits);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    private void ExitGame()
    {
        Debug.Log("Exit button clicked!");
        Application.Quit();
    }

    private void Credits()
    {
        SceneManager.LoadScene(gameSceneName2);
    }
}
