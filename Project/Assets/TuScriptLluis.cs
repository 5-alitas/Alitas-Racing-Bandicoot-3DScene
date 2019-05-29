using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuScriptLluis : MonoBehaviour
{
    private Vector3 v_rot;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        v_rot = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(v_rot, speed);
    }
}
