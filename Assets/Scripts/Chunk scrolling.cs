using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunkscrolling : MonoBehaviour
{

    [SerializeField] float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
}
