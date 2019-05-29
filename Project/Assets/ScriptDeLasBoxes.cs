using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDeLasBoxes : MonoBehaviour
{
    private Vector3 v_rot;
    public float speed_rot = 1.0f;

    private bool moving_up = false;
    public float speed_move = 1.0f;
    private float initial_pos;
    public float range = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        v_rot = new Vector3(0, 1, 0);
        initial_pos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(v_rot, speed_rot);

        if (moving_up)
        {
            transform.Translate(Vector3.up * speed_move * Time.deltaTime);
            if (transform.position.y >= initial_pos + range)
            {
                moving_up = !moving_up;
            }
        }
        else
        {
            transform.Translate(-Vector3.up * speed_move * Time.deltaTime);
            if (transform.position.y <= initial_pos - range)
            {
                moving_up = !moving_up;
            }
        }
    }
}
