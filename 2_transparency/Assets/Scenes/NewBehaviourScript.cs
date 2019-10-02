using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime * 0.1f;
        if (2.0 * Mathf.PI < timeElapsed) timeElapsed -= 2.0f * Mathf.PI;

        this.transform.position = new Vector3(0.0f, 0.0f, -1f * Mathf.Sin(timeElapsed));
    }
}
