using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public string nameScene;
    string sceneName;
    float timer = 0f;

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        sceneName = currentScene.name;

        if (sceneName == "Game")
        {
            Score.score = 0;
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if((sceneName == "GameOver" || sceneName == "Win") && timer > 3f)
        {
            LoadLevel();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnApplicationQuit();
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(nameScene);
    }

    public void OnApplicationQuit()
    {
        Debug.Log("I Wanna Quit!");
        Application.Quit();
    }
}
