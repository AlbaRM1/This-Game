using UnityEngine;

public class PlatformMovingY : MonoBehaviour
{
    [SerializeField] private Transform _movingToDot1Y;
    [SerializeField] private Transform _movingToDot2Y;
    [SerializeField] private float _speed;
    private bool _moved = false;

    private void FixedUpdate()
    {
        MovePlatform();
    }

    private void MovePlatform()
    {
        if (transform.position.y <= _movingToDot2Y.position.y && !_moved)
        {
            TranslateY(_speed);

            if(transform.position.y >= _movingToDot2Y.position.y)
            {
                _moved = true;
            }
        }
        else if (transform.position.y >= _movingToDot1Y.position.y && _moved)
        {
            TranslateY(-_speed);

            if (transform.position.y <= _movingToDot1Y.position.y)
            {
                _moved = false;
            }
        }
    }

    private void TranslateY(float speed) 
    {
        Vector3 movement = new Vector3(0, 1, 0);

        transform.Translate(movement * speed * Time.fixedDeltaTime);
    }
}