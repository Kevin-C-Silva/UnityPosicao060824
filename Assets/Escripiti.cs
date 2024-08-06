using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escripiti : MonoBehaviour
{
    Vector3 m;

    // Start is called before the first frame update
    void Start()
    {
        //m = new Vector3(5, 10, 3); pode ser usado no lugar do "Vector m; m.x m.y m.z;"
        m.x = 5;
        m.y = 10;
        m.z = 3;
        transform.position = m;
        m.Set(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        /*m.x = 0;
        m.y = 0;
        m.z = 0;*/
        if(Input.GetKey(KeyCode.D))
        {
            m.x = 0.01f;
            transform.Translate(m);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            m.x = -0.01f;
            transform.Translate(m);
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            m.y = 0.1f;
            transform.Translate(m);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            m.z = 0.01f;
            transform.Translate(m);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            m.z = -0.01f;
            transform.Translate(m);
        }
        else if (Input.GetKey(KeyCode.X))
        {
            m.y = -0.1f;
            transform.Translate(m);
        }
        m.Set(0, 0, 0);
    }
}
