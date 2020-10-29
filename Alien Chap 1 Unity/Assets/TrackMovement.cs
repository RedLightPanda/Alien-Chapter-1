using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Wallsmoved();
    }

    void Wallsmoved()
    {
        transform.Translate(Vector3.back * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Ship_Player player = other.transform.GetComponent<Ship_Player>();

            if (player != null)
            {
                player.Damage();
            }
        }
    }
}
