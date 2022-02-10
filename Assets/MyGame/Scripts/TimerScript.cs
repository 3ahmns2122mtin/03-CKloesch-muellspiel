using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float currentTime = 0;
    public Text currentTimeText;
    public bool timeRunning = true;
    public Text hudTimeText;
    public GameObject stinkyTrash;

    private float gradientPoison = 0;

    private string currentTimeString;
    void Start()
    {
        currentTimeText.text = "";
    }

    
    void Update()
    {
        if (timeRunning)
        {
            currentTime += Time.deltaTime;
            int minutes = (int)currentTime / 60;
            int seconds = (int)currentTime % 60;
            float hundreds = currentTime * 100;
            hundreds = (hundreds % 100);
            currentTimeString = string.Format("{0}:{1:00}", minutes, seconds);
            hudTimeText.text = currentTimeString;
        }
        if (currentTime >= 15)
        {
            gradientPoison = 1;
            //hier müsste man jetzt etwas an der bildlichen Darstellung des Mülls ändern!
        }
    }
}
