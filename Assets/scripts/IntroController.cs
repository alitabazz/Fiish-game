using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroController : MonoBehaviour
{
    [SerializeField] private Button goButton;
    [SerializeField] private string gameSceneName;

    // Start is called before the first frame update
    void Start()
    {
        goButton.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    private void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
