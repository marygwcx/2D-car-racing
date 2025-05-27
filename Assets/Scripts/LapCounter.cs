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
    public TextMeshProUGUI lapText;

    void Start()
    {
        //UpdateLapText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            currentLap++;
            Debug.Log("Lap: " + currentLap);
            lapText.text = "Lap: " + currentLap + " / " + totalLaps;

            if (currentLap >= totalLaps + 1)
            {
                SceneManager.LoadScene("Level2");
            }
        }
    }

    //void UpdateLapText()
    //{
    //    lapText.text = "Lap: " + currentLap + " / " + totalLaps;
    //}

}
