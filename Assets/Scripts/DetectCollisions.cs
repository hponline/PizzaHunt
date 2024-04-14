using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    SoundManager soundManagerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        soundManagerScript = GameObject.Find("AudioManager").GetComponent<SoundManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        // once kendini yok eder sonra carptigi nesneyi
        soundManagerScript.Death();
        Destroy(gameObject);
        Destroy(other.gameObject);

    }
}
