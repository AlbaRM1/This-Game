using UnityEngine;

public class PlatformMovingX : MonoBehaviour
{
    [SerializeField] private Transform _movingToDot1X;
    [SerializeField] private Transform _movingToDot2X;
    [SerializeField] private float _speed;
    private bool _moved = false;

    private void FixedUpdate()
    {
        MovePlatform();
    }

    private void MovePlatform()
    {
        if (transform.position.x <= _movingToDot2X.position.x && !_moved)
        {
            TranslateY(_speed);

            if(transform.position.x >= _movingToDot2X.position.x)
            {
                _moved = true;
            }
        }
        else if (transform.position.x >= _movingToDot1X.position.x && _moved)
        {
            TranslateY(-_speed);

            if (transform.position.x <= _movingToDot1X.position.x)
            {
                _moved = false;
            }
        }
    }

    private void TranslateY(float speed) 
    {
        Vector3 movement = new Vector3(1, 0, 0);

        transform.Translate(movement * speed * Time.fixedDeltaTime);
    }
}