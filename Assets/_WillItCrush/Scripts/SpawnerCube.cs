using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCube : MonoBehaviour
{
    public List<GameObject> cube = new List<GameObject>();
    float nextSpawn = 0f;
    public float time = 1f,minPosY, maxPosY;
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            Instantiate(cube[Random.Range(0, cube.Count)], new Vector3(Random.Range(minPosY,maxPosY), 6f, 5f), Quaternion.identity);
            nextSpawn = Time.time + time;
        }
    }
}
