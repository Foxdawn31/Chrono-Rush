using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunkspawner : MonoBehaviour
{
    [SerializeField] float spawnDistance = 20f;
    [SerializeField] GameObject chunkPrefab;
    private GameObject Lastchunk;


    void Start()
    {
        float max = float.MinValue;
        foreach (Transform child in transform)
        {
            Debug.Log(child.name);
            if (child.transform.position.z > max)
            {
                max = child.transform.position.z;
                Lastchunk = child.gameObject;
            }
        }
    }

    void Update()
    {
        Debug.Log(Lastchunk.transform.position.z);

        if (Lastchunk.transform.position.z < spawnDistance)
        {
            SpawnChunk();
        }

    }
    private void SpawnChunk()
    {
        GameObject newChunk = Instantiate(chunkPrefab, new Vector3(0f, 0f, Lastchunk.transform.position.z + spawnDistance), Quaternion.identity, transform);
        Lastchunk = newChunk;
    }

}
