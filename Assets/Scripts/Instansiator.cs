using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instansiator : MonoBehaviour {

    public GameObject[] prefab;
    int prefabLimit = 10;
    int prefabCount = 0;
    float InstantiateTimer = 2f;

    void FixedUpdate()
    {
        if (prefabCount < prefabLimit)
        {
            MakeRandomPrefab();
        }
    }
    void MakeRandomPrefab()
    {
        int arrayIndex = Random.Range(0, prefab.Length);

        InstantiateTimer -= Time.deltaTime;
        if (InstantiateTimer <= 0)
        {
            GameObject newprefab = Instantiate(prefab[arrayIndex]) as GameObject;
          
            float x = Random.Range(-5, 5);
            float y = Random.Range(5, 4);

            newprefab.transform.position = new Vector2(x, y);
            prefabCount++;

            InstantiateTimer = 2f; 
        }
    }
}
