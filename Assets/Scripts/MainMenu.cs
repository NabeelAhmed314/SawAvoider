using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void onPlayButonClicked()
    {
        SceneManager.LoadScene("lobby");
    }

    public void onQuitButtonClicked()
    {
        // UnityEditor.EditorApplication.isPlaying = false;
        // Application.Quit();
    }

}
