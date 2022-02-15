using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 35; i++)
        {
            Vector3 position = new Vector3(Random.Range(-4f, 4f), 0, Random.Range(0f, 90f));
            GameObject clone = Instantiate(cube);
            clone.transform.position = position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
