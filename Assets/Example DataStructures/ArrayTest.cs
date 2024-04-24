using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public GameObject[] arrayOfObjects;

    // Start is called before the first frame update
    void Start()
    {
        arrayOfObjects = new GameObject[5];

        arrayOfObjects[5].SetActive(true);
        GameObject[] newGameObject = new GameObject[6];
        for(int i = 0;i< arrayOfObjects.Length; i++)
        {
            newGameObject[i] = arrayOfObjects[i];
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
