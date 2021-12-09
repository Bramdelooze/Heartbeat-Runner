using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnableObject;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private float particleMoveSpeed = 1;
    [SerializeField] private float waitBeforeSpawnSpeed = .8f;
    [SerializeField] private int badCellSpawnRate = 1;


    private void Start()
    {
        StartCoroutine("SpawnTimer");
    }

    IEnumerator SpawnTimer()
    {
        for(; ; )
        {
            InstantiateObject();
            yield return new WaitForSeconds(waitBeforeSpawnSpeed);
        }
    }

    void InstantiateObject()
    {
        GameObject randomGameobject = RandomGameObject();
        float ZPosition = randomGameobject.transform.position.z;
        GameObject spawnedObject = Instantiate(randomGameobject, SpawnPointWithoutZ(spawnPoints[RandomNumber(0, spawnPoints.Length)].position, ZPosition), Quaternion.identity);
        spawnedObject.GetComponent<Rigidbody2D>().velocity = new Vector2(particleMoveSpeed, 0);
    }

    GameObject RandomGameObject()
    {
        if (RandomNumber(1, 12) > badCellSpawnRate)
        {
            return spawnableObject[0];
        }
        else
        {
            return spawnableObject[1];
        }
    }

    Vector3 SpawnPointWithoutZ(Vector3 spawnPoint, float originalZPos)
    {
        return new Vector3(spawnPoint.x, spawnPoint.y, originalZPos);
    }

    int RandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }
}
