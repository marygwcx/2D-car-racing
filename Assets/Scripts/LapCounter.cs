using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCounter : MonoBehaviour
{
    private int laps = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Finish"))
        {
            laps++;
            Debug.Log("Lap: " + laps);
        }
        
    }
    public int GetCurrentLap()
    {
        return laps;
    }
}
