using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;    // How fast the player moves
    public float xRange = 10.0f;   // Horizontal movement limit

    public GameObject projectilePrefab;

    private float horizontalInput;

    void Update()
    {
        // 👇 Get horizontal input from keyboard (A/D or Left/Right arrows)
        horizontalInput = Input.GetAxis("Horizontal");

        // 👇 Move the player left-right based on input
        Vector3 movement = Vector3.right * horizontalInput * speed * Time.deltaTime;
        transform.Translate(movement);

        // 👇 Keep the player within bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}