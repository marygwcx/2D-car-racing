using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapUI : MonoBehaviour
{
    public Text lapText;
    public LapCounter lapCounter;
    void Update()
    {
        lapText.text = "Lap: " + lapCounter.GetCurrentLap();
    }
}
