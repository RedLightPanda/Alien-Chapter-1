using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Enemy : MonoBehaviour
{

    [SerializeField]
    public float _speed = 1f;

    private Ship_Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Ship_Player>();

        if (_player == null)
        {
            Debug.LogError("Player Home");
        }
    }

    // Update is called once per frame
    void Update()
    {
        CaluclateMovement();
    }

    void CaluclateMovement()
    {
        transform.Translate(Vector3.back * _speed * Time.deltaTime);

        if (transform.position.z < -10)
        {
            float randomX = Random.Range(-8, 8);
            float randomY = Random.Range(-3.5f, 5);
            transform.position = new Vector3(randomX, randomY, 10);
        }
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

            Destroy(this.gameObject);
        }  
        
        if (other.gameObject.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
