using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Vector3 initial_pos;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        initial_pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("car trigger"))
        {
            transform.position = initial_pos;
        }
    }
}
