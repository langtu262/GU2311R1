using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraylistSam : MonoBehaviour
{
    public int[] array;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Debug.Log(array[i] + "\t");
        }
        int max = array[0];
        int vitri = 0;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                vitri = i + 1;
            }
        }
        Debug.Log("gia tri lon nhat cua mang la: " + max + " o phan tu thu: " + vitri);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
