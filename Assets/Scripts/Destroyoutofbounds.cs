using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyoutofbounds : MonoBehaviour
{
    // avci ile hayvan mesafesi
    public float topBounds = 40.0f;

    // avciyi gecme mesafesi
    public float lowerBounds = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
            
        }
        else if (transform.position.z < lowerBounds)
        {
            Destroy (gameObject);
            
        }
    }
}
