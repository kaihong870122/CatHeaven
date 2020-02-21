using UnityEngine;
using System;
using UnityEngine.UI;


public class Arrow : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-1f, 0, 0);
        }
    }

    private void Start()
    {
        
    }



    public void Right(int v)
    {
        gameObject.transform.position += new Vector3(v * 0.01f, 0, 0);
    }
    public void UP(int h)
    {
        gameObject.transform.position += new Vector3(0, h * 0.01f, 0);
    }

    

}

