using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockManager : MonoBehaviour
{

    public static FlockManager FM;
    public GameObject prefabOne;
    public GameObject prefabTwo;
    public int numEntities = 20;
    public GameObject[] allEntities;
    public Vector3 limits = new Vector3(10, 10, 10);
    public Vector3 goalPos = Vector3.zero;

    [Header ("Flock Settings")]
    [Range(0.0f, 5.0f)]
    public float minSpeed;
    [Range(0.0f, 5.0f)]
    public float maxSpeed;
    [Range(1.0f, 10.0f)]
    public float neighbourDistance;
    [Range(1.0f, 5.0f)]
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        allEntities = new GameObject[numEntities];
        for (int i = 0; i < numEntities; i++) {
            Vector3 pos = this.transform.position + new Vector3(Random.Range(-limits.x, limits.x), Random.Range(-limits.y, limits.y), Random.Range(-limits.z, limits.z));

        if (Random.Range(0, 100) < 50) {
            allEntities[i] = Instantiate(prefabOne, pos, Quaternion.identity);
        } else {
            allEntities[i] = Instantiate(prefabTwo, pos, Quaternion.identity);
        }

            
        }
        FM = this;
        goalPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 10) {
            goalPos = this.transform.position + new Vector3(Random.Range(-limits.x, limits.x), Random.Range(-limits.y, limits.y), Random.Range(-limits.z, limits.z));

        }
    }
}
