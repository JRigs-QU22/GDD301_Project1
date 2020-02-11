﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Red;
    public GameObject Blue;
    public GameObject Green;
    public GameObject Yellow;
    int randoPrefab;
    public float speed = 8f; 
    float leftRightEdges = 7.5f; 

    float chanceDirectionChange = 0.05f; 

    public float secsBetweenLaunch = 2f; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchCube", 2f, secsBetweenLaunch);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; 
        pos.x += speed * Time.deltaTime; 
        transform.position = pos;

        if (pos.x < -leftRightEdges)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftRightEdges) 
        {

            speed = -Mathf.Abs(speed);
        }
    }
    void FixedUpdate()
    {

        if (Random.value < chanceDirectionChange) 
        {
            speed *= -1;

        }

    }
    void LaunchCube()
    {
        randoPrefab = Random.Range(0, 4);
        if (randoPrefab == 0)
        {
            GameObject red = Instantiate(Red) as GameObject;
            red.transform.position = transform.position;
        }
        else if (randoPrefab == 1)
        {
            GameObject blue = Instantiate(Blue) as GameObject;
            blue.transform.position = transform.position;
        }
        else if (randoPrefab == 2)
        {
            GameObject green = Instantiate(Green) as GameObject;
            green.transform.position = transform.position;
        }
        else if (randoPrefab == 3)
        {
            GameObject yellow = Instantiate(Yellow) as GameObject;
            yellow.transform.position = transform.position;
        }
    }
}