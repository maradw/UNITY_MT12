using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public int directionX;
    public float speed;
    public int directionY;
    private SpriteRenderer _compSpriteR;
    private Transform _compTransform;

    private void Awake()
    {
       _compSpriteR = GetComponent<SpriteRenderer>();
        _compTransform = GetComponent<Transform>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true && _compTransform.position.y < 3.429)
        {
            directionY = 1;
        }
        else if (Input.GetKey(KeyCode.S) == true && _compTransform.position.y > -3.429)
        {
            directionY = -1;
        }
        else if (Input.GetKey(KeyCode.A) == true && _compTransform.position.x > -8)
        {
            directionX = -1;
            _compSpriteR.flipX = false;
        }
        else if (Input.GetKey(KeyCode.D) == true && _compTransform.position.x < 8)
        {
            directionX = 1;
            _compSpriteR.flipX = true;
        }
        else
        {
            directionY = 0;
            directionX = 0;
        }
        _compTransform.position = new Vector2(_compTransform.position.x + speed * directionX * Time.deltaTime, _compTransform.position.y + speed * directionY * Time.deltaTime);

    }

}
