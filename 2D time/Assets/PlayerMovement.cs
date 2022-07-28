using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 playerPosition = transform.position;
            playerPosition.y += speed *Time.deltaTime;
            transform.position = playerPosition;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector2 playerPosition = transform.position;
            playerPosition.y -= speed * Time.deltaTime;
            transform.position = playerPosition;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 playerPosition = transform.position;
            playerPosition.x += speed * Time.deltaTime;
            transform.position = playerPosition;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector2 playerPosition = transform.position;
            playerPosition.x -= speed * Time.deltaTime;
            transform.position = playerPosition;
        }
    }
    void Movement()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");
        Vector2 move = new Vector2(xAxis, yAxis);

        move.Normalize();
        move *= speed * Time.deltaTime;

        transform.position += (Vector3)move;
    }
}
