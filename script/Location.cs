using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public static List<Transform> point = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            point.Add(child);
            Debug.Log("added points");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
