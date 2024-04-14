using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public class Sayac : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int animalCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "animal")
        {
            animalCount++;
            Debug.Log("Sayac :" + animalCount);
        }
        else
        {
            Debug.Log("Çalýþmýyor");
        }
    }

    
    private void OnGUI()
    {
        GUI.Label(new Rect(100, 50, 100, 20), "Hunt: " + animalCount);
        
    }
}
