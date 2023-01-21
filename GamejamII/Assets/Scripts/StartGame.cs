using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour

    {
        public string LevelName;

    private void Start()
    {
        print("start");
    }
    public void LoadLevel()
        {
        SceneManager.LoadScene(LevelName);
        print("pressed");
        }

    }

    