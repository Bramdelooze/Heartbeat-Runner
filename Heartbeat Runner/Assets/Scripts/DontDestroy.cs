using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        RemoveDuplicates();
        // Makes sure this object isn't destroyed during scene changes
        DontDestroyOnLoad(this);
    }

    //Singleton pattern to remove duplicates of this script
    private void RemoveDuplicates()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
