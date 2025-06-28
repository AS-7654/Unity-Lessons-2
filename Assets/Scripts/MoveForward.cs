using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Move this field inside the class
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        // (optional initialization)
    }

    // Update is called once per frame
    void Update()
    {
        // move forward constantly
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
