using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Text Score;
    public Text Score2;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Points", 0);
        PlayerPrefs.SetInt("Points2", 0);
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score:" + PlayerPrefs.GetInt("Points");

        if (PlayerPrefs.GetInt("Points") < -19)
        {
            SceneManager.LoadScene("Scene_Lose");
        }
        if (PlayerPrefs.GetInt("Points") > 59)
        {
            SceneManager.LoadScene("Scene_Win");
        }
        //--------------------------------------------------------------
        Score2.text = "Score:" + PlayerPrefs.GetInt("Points2");

        if (PlayerPrefs.GetInt("Points2") < -19)
        {
            SceneManager.LoadScene("Scene_Lose2");
        }
        if (PlayerPrefs.GetInt("Points2") > 59)
        {
            SceneManager.LoadScene("Scene_Win2");
        }
    }

  
}
