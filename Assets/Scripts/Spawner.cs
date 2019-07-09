using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private int spawnRate;
    [SerializeField]
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1 / spawnRate, 1 / spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(enemy, this.transform.position, Quaternion.identity);
    }
}
