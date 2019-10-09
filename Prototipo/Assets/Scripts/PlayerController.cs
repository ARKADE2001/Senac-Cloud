using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    // Use this for initialization
    public Animator Animaçao;
    private Rigidbody2D Gravidade;

   


    public Transform Pisando;
    [HideInInspector] public bool TocandoChao = false;

    public float Velocidade;
    public float ForçaDoPulo = 5f;
    [HideInInspector] public bool viradoDireita = true;

    public Image vida;
    private MensagemControle MC;

    


    void Start()
    {

    }

    public void FixedUpdate()
    {

        float translationY = Input.GetAxis("Vertical");
        float translationX = Input.GetAxis("Horizontal") * Velocidade;
        transform.Translate(translationX, translationY, 0);
        transform.Rotate(0, 0, 0);

        Animaçao.SetFloat("velocidade", translationX);
        {
            if (Velocidade > 1)
            {
                if (!TocandoChao)

                    Animaçao.SetFloat("corre", translationX);
            }
            if (translationX != 0 && TocandoChao)
            {
                if (!TocandoChao)
                {
                    Animaçao.SetTrigger("pulando");
                }

            }
        }
        Animaçao.SetFloat("velocidade", translationX);
        {

        }
    }

    void Update()
    {



    }

        void Flip()
        {
            viradoDireita = !viradoDireita;
            Vector3 escala = transform.localScale;
            escala.x *= -1;
            transform.localScale = escala;
        }

        void SubtraiVida()
        {
            vida.fillAmount -= 0.1f;
            if (vida.fillAmount <= 0)
                MC.GameOver();
            Destroy(gameObject);
        }

    

}       