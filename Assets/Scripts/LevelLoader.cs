using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [TextArea]
    public string textField;
    // Start is called before the first frame update
    void Start()
    {
        SampleObject character = new SampleObject();
        character.name = "Rafael";
        character.life = 100;
        character.level = 15;
        character.xp = 10231;
        character.damage = 1;
        character.isDead = true;
        textField = JsonUtility.ToJson(character);
        
        PlayerPrefs.SetString("PROGRESS", textField);


        SampleObject loadedObject = new SampleObject();
        loadedObject = JsonUtility.FromJson<SampleObject>(textField);

        loadedObject.name = "NEW RAFAEL";

        //Weapon w = new Weapon(null, 10, 20);

        //Debug.Log(JsonUtility.ToJson(w));

    }

    // Update is called once per frame
    void Update()
    {



    }

    
}
