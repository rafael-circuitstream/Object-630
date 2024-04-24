using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to detect input from the Input class and send it to the player
/// </summary>
public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Vector2 directionToFace;
    [SerializeField] private float angleToTurn;
    private Player myPlayer;
    // Start is called before the first frame update
    void Start()
    {

        myPlayer = GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");

        Vector2 finalDirection = new Vector2(horizontalDirection, verticalDirection);

        directionToFace = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angleToTurn = Mathf.Atan2(directionToFace.y - transform.position.y, directionToFace.x - transform.position.x) * Mathf.Rad2Deg;

        myPlayer.Move(finalDirection, angleToTurn);

        if(Input.GetMouseButtonDown(0))
        {
            myPlayer.Shoot();
        }

        if(Input.GetMouseButtonUp(0))
        {
            //myPlayer.stopShooting();
        }

    }
}
