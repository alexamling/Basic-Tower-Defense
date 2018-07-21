using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy;

    private List<Enemy> enemies;

	// Use this for initialization
	void Start () {
        enemies = new List<Enemy>();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
