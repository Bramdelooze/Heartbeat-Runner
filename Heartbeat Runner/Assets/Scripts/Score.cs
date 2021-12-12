using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TMP_Text text;
    private float score = 0;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }

    public void ChangeScore(float value)
    {
        score += value;
    }

    public float GetScore()
    {
        return score;
    }
}
