using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private SpawnObject spawnObject;
    // Start is called before the first frame update
    void Awake()
    {
        spawnObject = FindObjectOfType<SpawnObject>();
    }

    public void WaveLevelUp()
    {
        spawnObject.ChangeWaveValues(spawnObject.particleMoveSpeed + 1f, 6);
    }
}
