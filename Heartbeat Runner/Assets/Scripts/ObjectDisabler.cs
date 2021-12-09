using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObjectDisabler : MonoBehaviour
{
    private GameObject heart;
    // Start is called before the first frame update
    void Awake()
    {
        heart = FindObjectOfType<HeartClick>().transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "Run scene") heart.SetActive(false);
        else
        {
            heart.SetActive(true);
        }
    }
}
