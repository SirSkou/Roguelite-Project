using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndStatus : MonoBehaviour {
    public int Health = 100;
    protected bool Alive = true;


	void Start () {
		
	}
	
	void FixedUpdate () {

        if (Alive =  false)
        {
            /*transform.position = Spawnpoint;*/
        }

        if (0 > Health)
        {
            Alive = false;
        }

	}
}
