﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tortoise : MonoBehaviour
{
    private Vector2 _initialPos;
    public Transform targetPos;
    private float _deltaX, _deltaY;
    private Collider2D collider2;
    public static bool isLocked;
    public AudioManager manager;



    void Start()
    {
        isLocked = false;
        collider2 = GetComponent<Collider2D>();
        collider2.enabled = true;
        _initialPos = transform.position;
    }




    private void Update()
    {

        if (Input.touchCount > 0 && !isLocked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPosition))
                    {
                        _deltaX = touchPosition.x - transform.position.x;
                        _deltaY = touchPosition.y - transform.position.y;
                    }
                    break;

                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPosition))
                    {
                        transform.position = new Vector2(touchPosition.x - _deltaX, touchPosition.y - _deltaY);
                    }
                    break;

                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - targetPos.position.x) <= 0.5f &&
                    Mathf.Abs(transform.position.y - targetPos.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(targetPos.position.x, targetPos.position.y);
                        //transform.position = targetPos.position;
                        collider2.enabled = false;
                        isLocked = true;
                        manager.Play("PutSound");
                    }

                    else
                    {
                        transform.position = new Vector2(_initialPos.x, _initialPos.y);
                        //transform.position = _initialPos;

                    }
                    break;
            }

        }



    }
}
