using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float distance;
    private float cou;
    // Start is called before the first frame update
    void Start()
    {
        cou = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cou = (cou + speed) % 360;
        float z;
        z = distance * Mathf.Sin(cou);
        transform.position = new Vector3(transform.position.x, transform.position.y, z+10);
    }
}
