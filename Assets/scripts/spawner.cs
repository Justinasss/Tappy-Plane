using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float spawnRate = 2;

    private float lastSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastSpawnTime + spawnRate)
        {
            Instantiate(pipePrefab);
            lastSpawnTime = Time.time;
        }
    }
}
