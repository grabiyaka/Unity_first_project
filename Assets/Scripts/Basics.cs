using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Basics : MonoBehaviour
{
    
    
    [SerializeField] private float nums;

    [NonSerialized] public int _num = 10;

    public int[] numbers = new int[6];

    public List<string> words = new List<string>();

    public string word;
    public int two = 2;
    public int five = 3; //   3+2

    public string nnk = "Nikitos16";
    public bool tf = true;

    private void Awake() {
        Debug.Log("Awake");
    }

    private void Start()
    {
        if(tf)
            for(int i = 0; i < 100; i++){
                Debug.Log("Start" + i);
            }
    }

    void Info()
    {
        if(_num == 10)
            Debug.Log(word + _num);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate() {
        Debug.Log("Late Update");
    }

    private void FixedUpdate() {
        Debug.Log("Fixed Update");
    }

    private void OnEnable() {
        Debug.Log("On Enable");
    }

    private void OnDestroy() {
        Debug.Log("On Destroy");
    }
}
