using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Deadline : MonoBehaviour
{
    private Image DeadlineBar;
    public float DeadlineFillSpeed = 1;

    // Start is called before the first frame update
    void Awake()
    {
        DeadlineBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Sit scene")
        {
            DeadlineBar.fillAmount += Time.deltaTime * DeadlineFillSpeed / 100;
        }
    }
}
