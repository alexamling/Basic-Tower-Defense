using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float Speed;

    private Vector3 velocity;
    private float bobSpeed;
    private float[] animSpeeds;
    private Transform[] childTransforms;
    private Vector3[] childRotations;
    
    
	public virtual void Start () {
        childTransforms = gameObject.GetComponentsInChildren<Transform>();
        childRotations = new Vector3[childTransforms.Length];

        for(int x = 0; x < childTransforms.Length; x++)
        {
            childTransforms[x].transform.rotation = Quaternion.Euler(
                Random.Range(0.0f, 90.0f),
                Random.Range(0.0f, 90.0f),
                Random.Range(0.0f, 90.0f));

            childRotations[x] = new Vector3(
                Random.Range(-5.0f, 5.0f),
                Random.Range(-5.0f, 5.0f),
                Random.Range(-5.0f, 5.0f));
        }

        animSpeeds = new float[childTransforms.Length];
        
        for(int x = 0; x < childTransforms.Length; x++)
        {
            animSpeeds[x] = Random.Range(1.0f, 2.0f);
        }
        bobSpeed = Random.Range(4.0f, 5.0f);
	}
	

	void FixedUpdate () {
        Move();
	}


    public virtual void Move()
    {
        float xPos = this.transform.position.x - Speed * Time.fixedDeltaTime;
        float yPos = Mathf.Cos(Time.fixedTime * bobSpeed) + 2;
        this.transform.position = new Vector3(xPos, yPos, 0);

        for (int x = 0; x < childTransforms.Length; x++)
        {
            childTransforms[x].Rotate(childRotations[x]);
        }
    }
}
