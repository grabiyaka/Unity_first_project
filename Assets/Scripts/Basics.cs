using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Basics : MonoBehaviour
{
    public GameObject[] objs = new GameObject[3];
    public Transform target;
    public BoxCollider box;
    public Light _light;

    public float speed = 2f, rotateSpeed = 10f;

    public Transform[] transfroms = new Transform[3];

    private void Start() {
        // obj.SetActive(false)
        //obj.GetComponent<Transform>().position = new Vector3(0, 10, 10);
        // target.position = new Vector3(0, 10, 10);
        // _light.intensity = 0.5f;
        // for (int i = 0; i < objs.Length; i++)
        // {
        //     objs[i].SetActive(false);
        // }
    }

    private void Update() {
        for (int i = 0; i < transfroms.Length; i++)
        {
            if(transfroms[i] != null){
                transfroms[i].Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
                transfroms[i].Rotate(new Vector3(-1, 0, 0) * rotateSpeed * Time.deltaTime);
                float posX = transfroms[i].position.x;
                if(posX > 10f && transfroms[i].gameObject.name == "Sphere"){
                    // Destroy(transfroms[i].gameObject);
                    transfroms[i].gameObject.SetActive(false);
                }
            }
        }
    }
}
