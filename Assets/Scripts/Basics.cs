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

    void Start()
    {
        Debug.Log(two);
        Debug.Log( five);
        five = five + 8;
        Debug.Log(five);
        Debug.Log(nnk);
        nnk = "Bhdn";
        Debug.Log(nnk);
        
        Debug.Log(nnk = "3+2");

        Debug.Log(tf = false);

        Info();
    }

    void Info()
    {
        if(_num == 10)
            Debug.Log(word + _num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
