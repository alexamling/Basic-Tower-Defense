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

        for (int x = 0; x < children.Length; x++)
        {
            animSpeeds[x] = Random.Range(1.0f, 2.0f);
        }
        bobSpeed = Random.Range(4.0f, 5.0f);
    }


    void FixedUpdate()
    {
        float xPos = this.transform.position.x - speed * Time.fixedDeltaTime;
        float yPos = Mathf.Cos(Time.time * bobSpeed) + 2;
        this.transform.position = new Vector3(xPos, yPos, 0);

        for (int i = 0; i < children.Length; i++)
        {
            children[i].localPosition = new Vector3(
                Mathf.Cos(i + Time.time),
                0,
                Mathf.Sin(i + Time.time));
        }
    }
}
