using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

public class GroundMovement : MonoBehaviour

{
    public int offsetX = -9;

    
    void Update()
    {
        transform.position -= new Vector3(6 * Time.deltaTime,0,0);
        if(transform.position.x <= offsetX)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }
    }
}
