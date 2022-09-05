using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;

    public float speedMultiplaier;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        speedMultiplaier += Time.deltaTime * 0.1f;

        timer += Time.deltaTime;

        if(timer > timeBetweenSpawns)
        {
            timer = 0;
            int randomNumber = Random.Range(0, 3);
            Instantiate(spawnObject, spawnPoints[randomNumber].transform.position, Quaternion.identity);
        }
    }
}
