using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTest : MonoBehaviour
{
    public Stack<string> commands = new Stack<string>();
    public Queue<string> line = new Queue<string>();
    void Start()
    {
        commands.Push("MOVE AN OBJECT");
        commands.Push("DELETED AN OBJECT");
        commands.Push("CHANGE BACKGROUND");
        commands.Push("SPAWNED PROP");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.X))
        {
            string lastCommand = commands.Peek();
            Debug.Log("Undo Command: " + lastCommand);
            Debug.Log("Number of Commands is " + commands.Count);
        }
    }
}
