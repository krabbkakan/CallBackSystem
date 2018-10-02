using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Player.OnEnemyHit += Damage;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Damage(Color color) {
        transform.GetComponent<Renderer>().material.color = color;
    }

    private void OnDisable()
    {
        Player.OnEnemyHit -= Damage;
    }
}
