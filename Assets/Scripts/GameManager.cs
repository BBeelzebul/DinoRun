using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2; 
    public GameObject cactus3;
    public GameObject bird;

    int chooseObstacle;

    public float timer;
    public float timeBetweenSpawns;

    public float speedMultiplier;
    private float distance;

    public TextMeshProUGUI scoreUI;
   
  
    void Update()
    {
        scoreUI.text = "Score: "+ distance.ToString("F0");
        speedMultiplier += Time.deltaTime * 0.3f;

        timer += Time.deltaTime;
        distance += Time.deltaTime * 1f;

        if (timer > timeBetweenSpawns)
        {
            timer = 0;
            GenerateObstacle();
        }
    }

    void GenerateObstacle()
    {
        chooseObstacle = Random.Range(0, 4);
        if (chooseObstacle == 0) { Instantiate(cactus1); }
        if (chooseObstacle == 1) { Instantiate(cactus2); }
        if (chooseObstacle == 2) { Instantiate(cactus3); }
        if (chooseObstacle == 3) { Instantiate(bird); }
    }
}
