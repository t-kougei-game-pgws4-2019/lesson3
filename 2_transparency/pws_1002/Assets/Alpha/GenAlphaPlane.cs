using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenAlphaPlane : MonoBehaviour
{
	[SerializeField] GameObject plane;

	[SerializeField] int maxNum = 30;
	[SerializeField] float planeDist = 0.3f;

	// Start is called before the first frame update
	void Start()
    {
		float y = 0;

		for (int i = 0; i < maxNum; i++)
		{
			Instantiate(plane, new Vector3(0, y, 0), Quaternion.identity);
			y += planeDist;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
