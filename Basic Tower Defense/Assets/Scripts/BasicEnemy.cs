using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour {

    public float speed;

    private Vector3 velocity;
    private float bobSpeed;
    private float[] animSpeeds;
    private Transform[] children;
    private Vector3[] childRotations;
    
    
	public virtual void Start () {
        children = new Transform[4];
        for (int i = 0; i < 4; i++)
        {
            children[i] = gameObject.transform.GetChild(i);
        }
        childRotations = new Vector3[children.Length];

        for(int x = 0; x < children.Length; x++)
        {
            children[x].transform.rotation = Quaternion.Euler(
                Random.Range(0.0f, 90.0f),
                Random.Range(0.0f, 90.0f),
                Random.Range(0.0f, 90.0f));

            childRotations[x] = new Vector3(
                Random.Range(-5.0f, 5.0f),
                Random.Range(-5.0f, 5.0f),
                Random.Range(-5.0f, 5.0f));
        }

        animSpeeds = new float[children.Length];
        
        for(int x = 0; x < children.Length; x++)
        {
            animSpeeds[x] = Random.Range(1.0f, 2.0f);
        }
        bobSpeed = Random.Range(4.0f, 5.0f);
	}
	

	void FixedUpdate () {
        float xPos = this.transform.position.x - speed * Time.fixedDeltaTime;
        float yPos = Mathf.Cos(Time.fixedTime * bobSpeed) + 2;
        this.transform.position = new Vector3(xPos, yPos, 0);

        for (int x = 0; x < children.Length; x++)
        {
            children[x].Rotate(childRotations[x]);
        }
    }
}
