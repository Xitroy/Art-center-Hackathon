using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    
    public int numEnemies = 4;
    public float lengthOfField = 10.0f;
    public float widthOfField = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            GameObject.Instantiate(enemyPrefab, new Vector3(Random.Range(-lengthOfField, lengthOfField), 1, Random.Range(-widthOfField, widthOfField)), Quaternion.identity);
        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
