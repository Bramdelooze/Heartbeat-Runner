using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float timerValue = 150;
    private float timerTime;
    private TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TMP_Text>();
        timerTime = timerValue;
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = timerTime.ToString("N0");
        if(timerTime >= 0)
        {
            timerTime -= Time.deltaTime;
        }
    }
}
