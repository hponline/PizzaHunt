using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject myPrefabs;

    private float horizontalInput;
    public float speed = 25.0f;

    // Platform X ekseni Siniri
    private float xRange = 18.0f;


    // Yurume
    private float xMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mathf.Clamp methodu verdigimiz konumu min/max arasinda sinirlar
        xMove = Mathf.Clamp(transform.position.x ,-xRange , xRange);
        transform.position = new Vector3(xMove,transform.position.y, transform.position.z);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Pizzayi ileri firlatma
            // "Prefabs" 1 ornegi cogaltir ve kullanir. "Instantiate" Ornek olusturma
            Instantiate(myPrefabs, transform.position, transform.rotation);
        }


    }
}
