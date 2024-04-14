using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    
    // hayvanlarin platform icindeki mesafesi sag sol X ekseni
    private float spawnRangeX = 18;

    // hayvanlarin avci ile mesafesi Z ekseni
    private float spawnPosZ = 25;

    // 2 saniye sonra baslar. 1 saniye de bir dongu tekrarlanir.
    private float startDelay = 2;
    private float startInterval = 1.05f;

    
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating methodu, fonksiyon/zaman/tekrar suresi alir ve surekli tekrarlanir
        InvokeRepeating("SpawnRandomAnimal", startDelay, startInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        // prefabs listemizin uzunlugu kadar rastgele eleman secer 
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Instantiate Ornek olusturur
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    

}
