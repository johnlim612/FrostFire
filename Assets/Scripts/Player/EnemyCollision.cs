using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public List<GameObject> snowmen { get; set; }
    private void Awake()
    {
        snowmen = new List<GameObject>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Snowman")
        {
            Debug.Log("Snowman Detected");
            snowmen.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Snowman")
        {
            Debug.Log("Snowmen Left");
            snowmen.Remove(other.gameObject);
        }
    }
}
