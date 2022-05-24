using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Back : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private string GameSceneName;

    // Start is called before the first frame update
    private void Start()
    {
        backButton.onClick.AddListener(GoBack);
    }

    private void GoBack()
    {
        SceneManager.LoadScene(GameSceneName);
    }

   
}
