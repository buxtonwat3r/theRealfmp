﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplte2: MonoBehaviour
{
    public void Mainmenu()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayGame()
    {

        SceneManager.LoadScene(4);
    }
}
