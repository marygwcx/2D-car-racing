using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public LapCounter lapCounter;
    public GameObject finishLine;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            lapCounter.SetCheckpointPassed();
            Debug.Log("Checpoint passed");
        }
    }
}
