using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy;

    private List<BasicEnemy> enemies;

	// Use this for initialization
	void Start () {
        enemies = new List<BasicEnemy>();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
