using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    [SerializeField] float speed = 1.2f;
    float distanceLeft = -2.85f;
    float distanceRight = 3.55f;
    int destination = 1;
    bool beenHit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!beenHit)
        {
            transform.Translate(new Vector3(destination, 0, 0) * speed * Time.deltaTime);
            if (transform.position.x >= distanceRight) destination = -1;
            else if (transform.position.x <= distanceLeft) destination = 1;
        }
    }
}
