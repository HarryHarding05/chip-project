using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilChipmunk : MonoBehaviour
{
    // Start is called before the first frame update

    public bool Shooting = false;
    public int timer;

    public GameObject evilWalnut;
    public GameObject Walnut;
    public static int health = 5;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }



    public bool MovingUp = true;

    // Update is called once per frame
    void Update()
    {




        if (MovingUp)
        {
            transform.position += new Vector3(0, 0.002f, 0);
        }


        if (!MovingUp)
        {
            transform.position += new Vector3(0, -0.002f, 0);
        }


        if (transform.position.y >0.01f)
        {
            MovingUp = false;
        }

        if (transform.position.y <-6)
        {
            MovingUp = true;
        }


        if (!Shooting)
        {

            if (Random.value<0.001f)
            {
                animator.SetBool("Shooting", true);
                Shooting = true;
                timer = 0;
            }
        }
        if (Shooting)
        {
            timer++;
        }

        if (timer==70)
        {
            if (Random.value<0.5f)
            {
                Instantiate(Walnut, transform.position, Quaternion.identity);
            }
            else

            {
                Instantiate(evilWalnut, transform.position, Quaternion.identity);
            }
        }

        if (timer > 150)
        {
            animator.SetBool("Shooting", false);
            Shooting = false;
            timer = 0;
        }

        if (health<1)
        {
            Application.LoadLevel("Win");
        }




    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    evilChipmunk.health--;
    }

}
