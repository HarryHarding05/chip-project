using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chipmunk : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 0.05f;
    public static int numberOfWalnuts=0;
    public static int health=5;
    public GameObject SquirrelWalnut;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -0.01f, 0)*speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0.01f, 0)*speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.01f, 0, 0)*speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.01f, 0, 0)*speed;
        }

        if (numberOfWalnuts>0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(SquirrelWalnut, transform.position, Quaternion.identity);
                numberOfWalnuts--;
            }
        }

        if (health<1)
        {
            Application.LoadLevel("Lose");
        }
        
    }
}
