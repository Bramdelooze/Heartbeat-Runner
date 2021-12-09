using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartClick : MonoBehaviour
{
    private bool isHeartFull = false;
    private Image heart;
    public float heartFillSpeed = 5;
    public float heartFullMargin = 0;
    private Score scoreScript;
    public float clickPoints = 10;

    public float timeToClick = 1;
    private float timerTime;

    [SerializeField] private ParticleSystem particles;


    private void Awake()
    {
        heart = this.GetComponent<Image>();
        if (scoreScript == null) scoreScript = FindObjectOfType<Score>();
        timerTime = timeToClick;
    }

    // Update is called once per frame
    void Update()
    {
        FillHeart();
        if(heart.fillAmount >= (1 - heartFullMargin))
        {
            isHeartFull = true;

            timerTime -= Time.deltaTime;
            if(timerTime <= 0 || Input.GetMouseButtonDown(0)) 
            {
                if (timerTime > 0)
                {
                    scoreScript.ChangeScore(clickPoints);
                    SpawnParticles();
                }
                isHeartFull = false;
                heart.fillAmount = 0;
                timerTime = timeToClick;
            }
        }

    }

    private void FillHeart()
    {
        if (heart.fillAmount < 1)
        {
            heart.fillAmount += Time.deltaTime * heartFillSpeed;
        }
    }

    private void SpawnParticles()
    {
        Instantiate(particles, transform);
    }
}