using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int MaxCount;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < MaxCount; i++)
        {
            Instantiate(obj, new Vector3(0, 0, 20f / MaxCount * i), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
