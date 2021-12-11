using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistanceToDesk : MonoBehaviour
{
    [SerializeField] private float totalDistanceToDesk = 500;
    [SerializeField] private GameObject desk;
    private float currentDistanceToDesk;
    private bool hasDeskSpawned;
    private TMP_Text text;
    private float subtractSpeed = 1;

    // Start is called before the first frame update
    void OnEnable()
    {
        currentDistanceToDesk = totalDistanceToDesk;
        text = GetComponent<TMP_Text>();
    }
    void OnDisable()
    {
        hasDeskSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        SubtractMeters();
    }

    private void SubtractMeters()
    {
        if (currentDistanceToDesk > 0)
            text.text = "Distance to desk:\n" + (currentDistanceToDesk -= (Time.deltaTime * subtractSpeed * 5)).ToString("N0") + " meters";
        else
            SpawnDesk();
    }

    private void SpawnDesk()
    {
        if(!hasDeskSpawned)
            Instantiate(desk);
        hasDeskSpawned = true;
    }

    public void ChangeSubtractSpeed(float speed)
    {
        subtractSpeed = speed;
    }
}
