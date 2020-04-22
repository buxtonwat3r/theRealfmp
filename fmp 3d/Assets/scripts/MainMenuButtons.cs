using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
        public void PlayGame() {

        SceneManager.LoadScene(0);
     
}

        public void QuitGame()
    {
        Application.Quit();
    }
    
    
        public void controls()

    {

        SceneManager.LoadScene(8);

    }
}
