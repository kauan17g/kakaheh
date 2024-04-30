using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 2;

        switch (number)
        {
            case 1:
                Debug.Log("numero 1");
                break;
            case 2:
                Debug.Log("numero 2");
                break;
            case 3:
                Debug.Log("numero 3");
                break;
            case 4:
                Debug.Log("numero 4");
                break;
            default:
                Debug.Log("nunhuma das opções");
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
