using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    public GameObject log;
    public double spawnRate = 2.57;
    private float timer = 0;
    public float heightOffset = 2;
    // Start is called before the first frame update
    void Start()
    {
        spawnLog();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnLog();
            timer = 0;

        }

    }
    void spawnLog()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(log, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
