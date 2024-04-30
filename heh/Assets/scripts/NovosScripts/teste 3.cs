using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 20;
        int c = 30;

        bool result1 = (a < b) && (b < c);
        Debug.Log("(a < b) && (b < c) ?" + result1);

        bool result2 = (a > b) || (b < c);
        Debug.Log("(a > B) || (b < c) ?" + result2);

        bool result3 = (a < b) && (b < c) || (a == 10);
        Debug.Log("(a < b) && (b < c) || (a == 10" + result3);

        bool result4 = !(a > b);
        Debug.Log("(a > b)?" + result4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
