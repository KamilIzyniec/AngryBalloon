using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;
    public GameObject[] baloons;
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 2f));

        int i = Random.Range(0, 3);
        {
            Instantiate(baloons[i], spawnPoints[i].position, spawnPoints[i].transform.rotation);
        }

        StartCoroutine(StartSpawning());
    }
}
