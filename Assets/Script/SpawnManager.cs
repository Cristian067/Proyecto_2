using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject[] animalsArray;
    private int animalIndex;

    private float spawnRangeX = 15f;
    private float spawnPosZ = 20f;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 2f;





    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

        
        
    }

    // Update is called once per frame
    void Update()
    {

      


        
    }

    private void SpawnRandomAnimal()
    {

        animalIndex = Random.Range(0, animalsArray.Length);

        Instantiate(animalsArray[animalIndex],RandomSpawn(), Quaternion.Euler(0,180,0));


    }

    private Vector3 RandomSpawn()
    {
        float linea = Random.Range(-spawnRangeX, spawnRangeX);

        return new Vector3(linea, 0, spawnPosZ);
    }



}
