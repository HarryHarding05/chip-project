using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walnut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-0.02f, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        chipmunk.numberOfWalnuts++;
        Destroy(gameObject);
    }
}
