using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location1 : MonoBehaviour
{
    public static List<Transform> point = new List<Transform>();
    public GameObject spiderPrefab, spiderContainer;
    public static float spiderBurstCount = 1;
    private float spawnTime = 2;
    Transform oldLocation;
    Transform location;
    float updateTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            point.Add(child);
        }
       
    }
    private void FixedUpdate()
    {
        if (Time.time > updateTime)
        {
            updateTime = Time.time * spawnTime;
            SpawnSpider();
        }
    }

    // Update is called once per frame
    public void SpawnSpider()
    {
        if (spiderContainer.transform.childCount < spiderBurstCount)
        {
            location = point[Random.Range(0, transform.childCount)];
            while (location == oldLocation)
            {
                location = point[Random.Range(0, transform.childCount)];

            }
            oldLocation = location;
            var spiderInstance = Instantiate(spiderPrefab, location.position, location.rotation);
            spiderInstance.transform.SetParent(spiderContainer.transform);
        }

    }
}
