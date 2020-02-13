using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePurple : MonoBehaviour
{
    public GameObject Purple;
    bool Entered = false;
    //public Text score;
    //int points;
    public AudioSource Dead;
    public AudioSource Point;
    // Start is called before the first frame update
    void Start()
    {
        //points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Entered == true)
        {
            if (Input.GetKeyDown(KeyCode.W))// on left click
            {
                Point.Play();
                Destroy(Purple, 0.2f);
                //points++;
                PlayerPrefs.SetInt("Points2", PlayerPrefs.GetInt("Points2") + 1);
                //score.text = "Score:" + points;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                PlayerPrefs.SetInt("Points2", PlayerPrefs.GetInt("Points2") - 1);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                PlayerPrefs.SetInt("Points2", PlayerPrefs.GetInt("Points2") - 1);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                PlayerPrefs.SetInt("Points2", PlayerPrefs.GetInt("Points2") - 1);
            }
        }
    }

    /*
 void OnCollisionEnter2D(Collision2D collision)
 {

     if (collision.gameObject.tag == "Good") 
     {
         Entered = true;
     }
 }
 void OnCollisionExit2D(Collision2D collision)
 {
     Entered = false;

 }
 */
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Good")
        {
            Entered = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Entered = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bad")
        {
            PlayerPrefs.SetInt("Points2", PlayerPrefs.GetInt("Points2") - 1);
            Dead.Play();
            Destroy(gameObject, 0.5f);
        }
    }
}
