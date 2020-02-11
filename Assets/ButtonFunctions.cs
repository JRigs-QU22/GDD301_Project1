using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("Scene_Game");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Scene_Rules");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Scene_Menu");
    }
}
