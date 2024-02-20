using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] private string CurrentScene;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main_Menu");
        }

        else if (Input.GetKeyDown(KeyCode.W) && CurrentScene == "Death_Scene")
        {
            SceneManager.LoadScene("Main_Menu");
        }
        else if (Input.GetKeyDown(KeyCode.C) && CurrentScene == "Main_Menu")
        {
            SceneManager.LoadScene("Controls");
        }
        else if (Input.GetKeyDown(KeyCode.F1) && CurrentScene == "Main_Menu")
        {
            SceneManager.LoadScene("Level_1");
        }
        else if (Input.GetKeyDown(KeyCode.F2) && CurrentScene == "Main_Menu")
        {
            SceneManager.LoadScene("Level_2");
        }
        else if (Input.GetKeyDown(KeyCode.F3) && CurrentScene == "Main_Menu")
        {
            SceneManager.LoadScene("Level_3");
        }
    }
}
