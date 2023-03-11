using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer;

    public float heightOffset = 4;

    // Start is called before the first frame update
    void Start()
    {
        pipeSpawnFun();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {

            pipeSpawnFun();
            timer = 0;
        }
    }

    void pipeSpawnFun()
    {
        float highestOffset = transform.position.y + heightOffset;
        float lowestOffset = transform.position.y - heightOffset;
        // Cloning my PreFabricated (Blueprint) GameObject
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(highestOffset, lowestOffset), 0), transform.rotation);
    }
}
