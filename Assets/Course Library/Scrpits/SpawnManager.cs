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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            int Randamals = Random.Range(0, Animals.Length - 1);
            Instantiate(Animals[Randamals], new Vector3(Random.Range(-xRange, xRange), 0, SpawnPointZ), Animals[Randamals].transform.rotation);
        }    
    }
}
