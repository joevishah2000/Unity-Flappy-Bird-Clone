using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesGenerator : MonoBehaviour
{
    public GameObject pipe;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GeneratePipes()); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GeneratePipes()
    {
        while (true){
            yield return new WaitForSeconds(4f);
            float randy = Random.Range(4.75f,2.67f); 
            pos = new Vector3(6f,randy,0f);
            Instantiate(pipe,pos,Quaternion.identity);
        }

    }
}
