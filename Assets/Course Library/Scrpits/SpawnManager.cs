using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Animals;
    private const float xRange = 10;
    private const float SpawnPointZ = 25;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 3.0f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnAnimals()
    {
        int Randamals = Random.Range(0, Animals.Length - 1);
        Instantiate(Animals[Randamals], new Vector3(Random.Range(-xRange, xRange), 0, SpawnPointZ),
            Animals[Randamals].transform.rotation);
    }

}
