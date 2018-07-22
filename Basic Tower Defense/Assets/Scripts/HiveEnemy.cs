using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveEnemy : MonoBehaviour {

    public float speed;

    private Vector3 velocity;
    private float bobSpeed;
    private float[] animSpeeds;
    private Transform[] children;
    private Vector3[] childRotations;


    public virtual void Start()
    {
        children = new Transform[6];
        for (int i = 0; i < 6; i++)
        {
            children[i] = gameObject.transform.GetChild(i);
        }

        animSpeeds = new float[children.Length];

        for (int i = 0; i < children.Length; i++)
        {
            animSpeeds[i] = Random.Range(1.0f, 2.0f);
            children[i].transform.localPosition = new Vector3(Mathf.Cos(i * (Mathf.PI / 3)), 0, Mathf.Sin(i * (Mathf.PI / 3)));
        }
        bobSpeed = Random.Range(4.0f, 5.0f);
    }


    void FixedUpdate()
    {
        float xPos = this.transform.position.x - speed * Time.fixedDeltaTime;
        float yPos = Mathf.Cos(Time.time * bobSpeed) + 2;
        gameObject.transform.position = new Vector3(xPos, yPos, 0);
        gameObject.transform.Rotate(new Vector3(0, speed, 0));
    }
}
