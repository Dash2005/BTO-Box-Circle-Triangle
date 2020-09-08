using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

    public GameObject[] projectiles;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Instantiate(projectiles[0], transform.position, Quaternion.identity);
            SquareButt();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //Instantiate(projectiles[1], transform.position, Quaternion.identity);
            TriangleButt();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //Instantiate(projectiles[2], transform.position, Quaternion.identity);
            CircleButt();
        }
    }

    public void SquareButt()
    {
        Instantiate(projectiles[0], transform.position, Quaternion.identity);

    }

    public void TriangleButt()
    {
        Instantiate(projectiles[1], transform.position, Quaternion.identity);

    }
    public void CircleButt()
    {
        Instantiate(projectiles[2], transform.position, Quaternion.identity);
    }
}
