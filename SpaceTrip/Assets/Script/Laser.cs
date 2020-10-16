using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    [SerializeField]
    private float _speed = 8.0f;

    private bool _isEnemyLaster = false;

    // Update is called once per frame
    void Update()
    {
        if (_isEnemyLaster == false)
        {
            MoveForward();
        }
        else
        {
            MoveDown();
        }
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        if(transform.position.z > 30)
        {
            if(transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            Destroy(this.gameObject);
        }
    }

    void MoveDown()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if(transform.position.y < -8)
        {
            if (transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            Destroy(this.gameObject);
        }
    }

    public void AssignEnemyLaser()
    {
        _isEnemyLaster = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && _isEnemyLaster == true)
        {
            Ship_Player player = other.GetComponent<Ship_Player>();

            if (player != null)
            {
                player.Damage();
            }
        }
    }
}
