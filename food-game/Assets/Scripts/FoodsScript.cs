using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodsScript : MonoBehaviour
{

    public GameObject[] FoodsPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        FoodsPrefabs = new GameObject[24];

        for (int i = 0; i < FoodsPrefabs.Length; i++)
            FoodsPrefabs = Resources.LoadAll("/Prefab/Food") as GameObject[];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
