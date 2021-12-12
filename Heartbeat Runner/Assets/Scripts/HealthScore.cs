using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthScore : MonoBehaviour
{
    private TMP_Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    public void ChangeText(string grade)
    {
        text.text = "De gezondheid van je karakter is: " + grade;
    }
}
