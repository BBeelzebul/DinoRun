using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject[] spawnObject;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;

    public float speedMultiplaier;
    private float distance;

    public TextMeshProUGUI scoreUI;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        scoreUI.text = "Score: "+ distance.ToString("F2");
        speedMultiplaier += Time.deltaTime * 0.1f;

        timer += Time.deltaTime;
        distance += Time.deltaTime * 0.5f;

        if(timer > timeBetweenSpawns)
        {
            timer = 0;
            int randomNumber = Random.Range(0, 3);
            int n = Random.Range(0, 3);
            GameObject prueba = Instantiate(spawnObject[n], spawnPoints[randomNumber].transform.position, Quaternion.identity);
        }
    }
}
