using System.Collections;
using System.Collections.Generic;
using UI_Driver;
using UnityEngine;

public class Ship_Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int CurrentHealth;
   
    public UI_Driver_System healthBar;
    private SpawnManager _SpawnManager;

    [SerializeField]
    private float _speed = 3.5f;

    [SerializeField]
    private GameObject _laserPrefab;

    [SerializeField]
    private float _fireRate = 0.5f;

    private float _canFire = -1f;

    // Start is called before the first frame update
    void Start()
    {
        _SpawnManager = GameObject.Find("Spawning_Manager").GetComponent<SpawnManager>();
        HealthSystem();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _canFire)
        {
            FireLaser();
        }
    }
    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8f, 8f), Mathf.Clamp(transform.position.y, -3.5f, 5f), 0);

    }
    void FireLaser()
    {
        _canFire = Time.time + _fireRate;
        Instantiate(_laserPrefab, transform.position + new Vector3(0, 0, 1f), Quaternion.identity);
    }


    //When player gets hit player takes damage.
    //If HP is zero Player dies.

    void HealthSystem()
    {
        CurrentHealth = 100;
        healthBar.SetHealth(CurrentHealth);
    }

    public void Damage()
    {
        TakeDamage(10);

        if (CurrentHealth == 0)
        {
            _SpawnManager.OnPlayerDeath();
           Destroy(this.gameObject);
        }
    }

    void TakeDamage(int Health)
    {
        CurrentHealth -= Health;
        healthBar.SetHealth(CurrentHealth);
    }

    
}
