using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    [SerializeField] private Transform _movingToDot1Z;
    [SerializeField] private Transform _movingToDot2Z;
    [SerializeField] private float _speed;
    private bool _moved = false;

    private void FixedUpdate()
    {
        MovePlatform();
    }

    private void MovePlatform()
    {
        if (transform.position.z <= _movingToDot2Z.position.z && !_moved)
        {
            TranslateY(_speed);

            if(transform.position.z >= _movingToDot2Z.position.z)
            {
                _moved = true;
            }
        }
        else if (transform.position.z >= _movingToDot1Z.position.z && _moved)
        {
            TranslateY(-_speed);

            if (transform.position.z <= _movingToDot1Z.position.z)
            {
                _moved = false;
            }
        }
    }

    private void TranslateY(float speed) 
    {
        Vector3 movement = new Vector3(0, 0, 1);

        transform.Translate(movement * speed * Time.fixedDeltaTime);
    }
}
