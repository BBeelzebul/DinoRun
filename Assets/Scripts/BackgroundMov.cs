using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

public class BackgroundMov : MonoBehaviour
{
    public int offsetX = -8;


    void Update()
    {
        transform.position -= new Vector3(1 * Time.deltaTime, 0, 0);
        if (transform.position.x <= offsetX)
        {
            transform.position = new Vector3(8, transform.position.y, 0);
        }
    }
}
