using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool movendoF = false;
    public bool movendoT = false;
    public bool pulo = false;
    public bool subindo = false;
    public bool descendo = false;
    public int altura = 0;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q) == true)
        {
            MovePersonagem(0.1f);
            movendoF = true;
        }

        if (Input.GetKey(KeyCode.E) == true)
        {
            MovePersonagem(-0.1f);
            movendoT = true;

        }
        if (Input.GetKey(KeyCode.B) == true)
        {
            subindo = true;

        }
        if (subindo)
        {
            ElevarPersonagem(0.2f);
            altura++;
        }
        if(altura == 100)
        {
            subindo = false;
            descendo = true;
        }
        if(descendo)
        {
            ElevarPersonagem(-0.2f);
        }
        if(altura == 0 && descendo == true)
        {
            ElevarPersonagem(0.0f);
            descendo = false;
        }

        if (movendoF)
        {
            MovePersonagem(0.01f);

        }
        if (movendoT)
        {
            MovePersonagem(-0.01f);

        }
  

        if (Input.GetKey(KeyCode.G) == true)
        {
            MovePersonagem(0.00f);

        }

    }


    void MovePersonagem(float valorX)
    {
        transform.position = new Vector3(transform.position.x + valorX, transform.position.y, transform.position.z);
    }

    void ElevarPersonagem(float valorY)
    {
        transform.position = new Vector3(transform.position.x , transform.position.y+ valorY, transform.position.z);
    }

}
