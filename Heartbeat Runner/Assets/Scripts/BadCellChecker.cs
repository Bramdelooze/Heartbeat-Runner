using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCellChecker : MonoBehaviour
{
    private Score scoreScript;
    [SerializeField] private float badCellPenalty = 50;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bad cell")
        {
            scoreScript.ChangeScore(-badCellPenalty);
        }
    }
}
