using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public GameObject[] arrays = new GameObject[5];
    public List<string> inventory = new List<string>();

    float timer;
    private void Start()
    {
        inventory.Add("KNIFE");
        inventory.Add("WOOD");
        inventory.Add("GLASSES");
        inventory.Add("FOOD");

    }

    private void Update()
    {
        timer += Time.deltaTime;
        
        if(timer > 3)
        {
            inventory.Remove("KNIFE");
            
            timer = 0;
        }
    }
}
