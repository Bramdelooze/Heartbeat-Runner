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
    // Start is called before the first frame update
    void Awake()
    {
        heart = GetComponentInChildren<HeartClick>().transform.parent.gameObject;
        distanceToDeskText = GetComponentInChildren<DistanceToDesk>().gameObject;
        timer = GetComponentInChildren<TimerScript>().transform.parent.gameObject;
        deadlineBar = GetComponentInChildren<Deadline>().transform.parent.gameObject;
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
        if(SceneManager.GetActiveScene().name == "Game Over")
        {
            timer.SetActive(false);
            deadlineBar.SetActive(false);
        }
    }
}
