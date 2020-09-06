using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor_B : MonoBehaviour
{
    [SerializeField]
    public float _speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationMovement();
    }

    void rotationMovement()
    {
        transform.Rotate(new Vector3(0f, 0f, _speed) * Time.deltaTime);
    }
}
