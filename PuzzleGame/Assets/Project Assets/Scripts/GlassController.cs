using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassController : MonoBehaviour
{
    private Vector2 _initialPos;
    private float _deltaX, _deltaY;
    void Start()
    {
        _initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
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
                        transform.position = _initialPos;
                    break;
            }

        }
    }
}
