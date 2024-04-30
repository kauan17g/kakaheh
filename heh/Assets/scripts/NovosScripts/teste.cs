using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //variaveis e tipos de dados
        int pontos = 10;
        float peso = 61.8f;
        double medida = 9.99;
        bool ativado = false;
        string saudacao = " olá, tudo bem?";


        Debug.Log("int" + pontos);
        Debug.Log("float" + peso);
        Debug.Log("double" + medida);
        Debug.Log("Booleana" + ativado);
        Debug.Log("string" + saudacao);

        //operadores Aritiméticos
        int soma = 3 + 3;
        int subtracao = 8 - 5;
        int multiplicacao = 3 * 9;
        float divisao = 20f / 6f;
        int resto = 10 % 5;


        Debug.Log("soma" + soma);
        Debug.Log("subtracao" + subtracao);
        Debug.Log("multiplicacao" + multiplicacao);
        Debug.Log("divisao" + divisao);
        Debug.Log("resto" + resto);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
