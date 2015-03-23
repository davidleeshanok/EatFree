using UnityEngine;
using System.Collections;

public class SkierSpawner : MonoBehaviour
{

    public GameObject skier;
    public Transform[] spawnPoints;
    public float spawnRate = 0;
    private float spawnTime = 0;

    void Update()
    {
        if (Time.time > spawnTime)
        {
            spawnSkier();
            spawnTime = Time.time + 5 - spawnRate;

            if((Time.time - Globals.startTime)/20 >= 3)
                spawnTime -= 3f;
            else
                spawnTime -= (Time.time - Globals.startTime)/20;

        }

    }

    private void spawnSkier()
    {
        Transform transform = spawnPoints [Random.Range(0, 12)];
        Instantiate(skier, transform.position, transform.rotation);
    }

}