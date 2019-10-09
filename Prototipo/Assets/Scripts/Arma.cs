using UnityEngine;
using System.Collections;

public class Arma: MonoBehaviour
{
    // Start is called before the first frame update

    public string arma;

    public int QuantidadeDeBalas = 30;
    public int Cartuchos = 5;

    public Transform Disparador;
    public GameObject Muniçao;


    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && QuantidadeDeBalas > 0) 
            shoot();
    }

   
    void shoot()

    {
        Instantiate(Muniçao, Disparador.position, Disparador.rotation);
    }


}

 
