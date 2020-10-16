using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InShip_2DPlayer : MonoBehaviour
{

    #region Varialbes

    [SerializeField]
    private float _Speed = 2.5f;

    private bool facingRight;

    SpriteRenderer _sprite;

    #endregion



    // Start is called before the first frame update
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        CalaculateMovement();
    }

    #region Helper Code
    void CalaculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(horizontalInput, 0);

        transform.Translate(direction * _Speed * Time.deltaTime);
        
        if(horizontalInput > 0)
        {
            Flip(true);
        }
        else if (horizontalInput < 0)
        {
            Flip(false);
        }
    }

    void Flip (bool faceRight)
    {
        if (faceRight == true)
        {
            _sprite.flipX = false;
        }
        else if(faceRight == false)
        {
            _sprite.flipX = true;
        }
    }

    #endregion
}
