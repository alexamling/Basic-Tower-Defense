using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float Speed;
    public int SubPieces;

    private Vector3 velocity;
    private float bobSpeed;
    private float[] animSpeeds;
    private float[] animProgress;
    

	// Use this for initialization
	public virtual void Start () {
        animSpeeds = new float[SubPieces];
        animProgress = new float[SubPieces];
        
        for(int x = 0; x < SubPieces; x++)
        {
            animSpeeds[x] = Random.Range(1.0f, 2.0f);
        }
        bobSpeed = Random.Range(4.0f, 5.0f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();
	}

    public virtual void Move()
    {
        float xPos = this.transform.position.x - Speed * Time.fixedDeltaTime;
        float yPos = Mathf.Cos(Time.fixedTime * bobSpeed) + 2;
        this.transform.position = new Vector3(xPos, yPos, 0);
    }
}
