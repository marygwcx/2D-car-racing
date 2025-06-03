using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LapCounter : MonoBehaviour
{
    public int totalLaps = 3;
    private int currentLap = 0;
    private bool checkpointPassed = false;
    public TextMeshProUGUI lapText;
    public string sceneName;

    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(checkpointPassed)
            {
                currentLap++;
                Debug.Log("Lap: " + currentLap);
                checkpointPassed = false;
                lapText.text = "Lap: " + currentLap + " / " + totalLaps;
            }
            

            if (currentLap >= totalLaps)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }

    public void SetCheckpointPassed()
    {
        checkpointPassed = true;
    }

    

}
