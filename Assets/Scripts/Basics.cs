using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Basics : MonoBehaviour
{
    
    public string word;

    private float nums;

    [NonSerialized] public int _num = 10;

    void Start()
    {
        Debug.Log(word + _num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
