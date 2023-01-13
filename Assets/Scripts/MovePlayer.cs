using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f;

    private void Awake() {

    }

    void Update()
    {
        // if (Input.GetKey(KeyCode.D)){
        //     transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        // } else if(Input.GetKey(KeyCode.A)){
        //     transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        // } else if(Input.GetKey(KeyCode.W)){
        //     transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        // } else if(Input.GetKey(KeyCode.S)){
        //     transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        // }

        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime * v);

        float h = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * h);
    }
}
