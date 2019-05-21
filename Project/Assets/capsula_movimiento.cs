using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsula_movimiento : MonoBehaviour
{

    private bool start = false;
    private float time_to_wait = 0.0f;
    private bool moving_up = false;
    public float speed = 5;
    private float initial_pos;
    public float range = 5;
    // Start is called before the first frame update
    void Start()
    {
        time_to_wait = Random.value * 5;
        initial_pos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (!start)
        {
            if (time_to_wait < Time.realtimeSinceStartup)
            {
                start = true;
            }
        }
        else
        {
            if (moving_up)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                if (transform.position.y >= initial_pos + range)
                {
                    moving_up = !moving_up;
                }
            }
            else
            {
                transform.Translate(-Vector3.up * speed * Time.deltaTime);
                if (transform.position.y <= initial_pos - range)
                {
                    moving_up = !moving_up;
                }
            }
        }
    }
}
