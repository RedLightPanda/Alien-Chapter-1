using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShip_AI : MonoBehaviour
{
    [SerializeField]
    public float _speed = 1f;

    [SerializeField]
    private int _Hits = 10;

    [SerializeField]
    private GameObject _armor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    //Movement
    void CalculateMovement()
    {
        transform.Translate(Vector3.down*_speed*Time.deltaTime);
    }

    //Taking Damage from player Laser
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Laser")
        {
            MainHP();
            Destroy(other.gameObject);

            if (_Hits < 1)
            {
                Destroy(this.gameObject);
            }
            else if(_Hits < 6)
            {
                Destroy(_armor);  
            }
                        
        }

    }

   

    //Hit points Main body
    public void MainHP()
    {
        _Hits--;
    }

}
