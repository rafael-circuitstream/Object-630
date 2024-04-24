using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{

    public Dictionary<string, int> dictionary = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        dictionary.Add("apples", 1);
        dictionary.Add("bananAs", 2);
        dictionary.Add("grapes", 3);

        Debug.Log(dictionary["bananas"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
