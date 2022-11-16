using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2; 
    public GameObject cactus3;
    public GameObject bird;

    int chooseObstacle;

    public float timer;
    public float timeBetweenSpawns;
    public float score;
    public float highScore;
    public float speedMultiplier;

    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI highScoreUI;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        highScore = PlayerPrefs.GetFloat("Highscore");
    }

    void Update()
    {
        scoreUI.text = "S " + score.ToString("F0");
        highScoreUI.text = "HS " + highScore.ToString("F0");

        score += Time.deltaTime * 1f;
        speedMultiplier += Time.deltaTime * 0.3f;

        timer += Time.deltaTime;

        if (timer > timeBetweenSpawns)
        {
            timer = 0;
            GenerateObstacle();
        }

        if (score > highScore)
        {
            PlayerPrefs.SetFloat("Highscore", score);
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
