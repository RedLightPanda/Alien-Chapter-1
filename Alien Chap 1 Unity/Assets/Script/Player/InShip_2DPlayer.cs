using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InShip_2DPlayer : MonoBehaviour
{

    #region Varialbes

    [SerializeField]
    private float _Speed = 2.5f;

    private bool facingRight;

    #endregion



    // Start is called before the first frame update
    void Start()
    {
        facingRight = true; 
    }

    // Update is called once per frame
    void Update()
    {
        CalaculateMovement();

        Flip();
    }

    #region Helper Code
    void CalaculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(horizontalInput, 0);

        transform.Translate(direction * _Speed * Time.deltaTime);
    }

    private float Flip (float horizontal)
    {
        if (horizontal >0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector2 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    #endregion
}
