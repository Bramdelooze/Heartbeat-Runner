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
            if (DeadlineBar.fillAmount < 1) DeadlineBar.fillAmount += Time.deltaTime * DeadlineFillSpeed / 100;
            else SceneManager.LoadScene("Game Over");
        }
    }
}
