using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float velocidade = 5f;
    public float manaInicial = 100f;
    public float TaxaDeDecrementoMana = 1f;
    public float TaxaDeRecuperaMana = 1f;
    public float manaAtual;
    public Slider SliderMana;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        manaAtual = manaInicial;
    }

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;

        rb.velocity = new Vector2(eixoX, eixoY);

        if (eixoX != 0 || eixoY != 0)
        {
            manaAtual -= TaxaDeDecrementoMana * Time.deltaTime;
            if (manaAtual <=0)
            {
                manaAtual = 0;
                SceneManager.LoadScene(2);
            }
            AtualizarSliderMana();

        }
    }

    void AtualizarSliderMana()
    {
        SliderMana.value = manaAtual / manaInicial;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Recovery"))
        {
            Debug.Log("conseguiu recuperar");
            StartCoroutine(RecuperaMana());
        }
        
    }

    IEnumerator RecuperaMana()
    {
        while (manaAtual < manaInicial)
        {
            manaAtual += TaxaDeRecuperaMana * Time.deltaTime;
            AtualizarSliderMana();
            yield return null;
        }
    }
}

