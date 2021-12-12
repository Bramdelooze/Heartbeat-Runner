using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObjectDisabler : MonoBehaviour
{
    private GameObject heart;
    private GameObject distanceToDeskText;
    private GameObject timer;
    private GameObject deadlineBar;
    private Score score;
    private HealthScore healthScore;

    private bool hasRunGameOver;

    private float endScore;
    private float sittingTimer;
    private float sittingTimerHighest;
    // Start is called before the first frame update
    void Awake()
    {
        heart = GetComponentInChildren<HeartClick>().transform.parent.gameObject;
        distanceToDeskText = GetComponentInChildren<DistanceToDesk>().gameObject;
        timer = GetComponentInChildren<TimerScript>().transform.parent.gameObject;
        deadlineBar = GetComponentInChildren<Deadline>().transform.parent.gameObject;
        score = GetComponentInChildren<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "Run scene")
        {
            heart.SetActive(false);
            distanceToDeskText.SetActive(false);
        }
        else
        {
            heart.SetActive(true);
            distanceToDeskText.SetActive(true);
            timer.SetActive(true);
            deadlineBar.SetActive(true);
        }
        if (SceneManager.GetActiveScene().name == "Sit scene")
        {
            sittingTimer += Time.deltaTime;
        }
        else
        {
            if (sittingTimer > sittingTimerHighest)
                sittingTimerHighest = sittingTimer;
            sittingTimer = 0;
        }
        if (SceneManager.GetActiveScene().name == "Game Over" && !hasRunGameOver)
        {
            timer.SetActive(false);
            deadlineBar.SetActive(false);
            endScore = score.GetScore();
            score.transform.parent.gameObject.SetActive(false);
            FindObjectOfType<EndScore>().ChangeEndScoreText(endScore);
            healthScore = FindObjectOfType<HealthScore>();
            if (sittingTimerHighest >= 27 && sittingTimerHighest <= 52) healthScore.ChangeText("matig");
            else if (sittingTimerHighest > 52) healthScore.ChangeText("slecht");
            else healthScore.ChangeText("goed");
            hasRunGameOver = true;
        }
    }
}
