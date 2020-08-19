using UnityEngine;

public class Ball : MonoBehaviour
{
    private Paddle _paddle;

    private Vector2 _paddleToBallVector;

    private bool _isStarted;

    [SerializeField] private float xPush = 2 , yPush = 16;

    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _paddle = FindObjectOfType<Paddle>();
        _paddleToBallVector = transform.position - _paddle.transform.position;
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isStarted) return;
        LockBallToPaddle();
        LaunchBall();
    }

    private void LaunchBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody2D.velocity = new Vector2(xPush, yPush);
            _isStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        transform.position = _paddle.transform.position + (Vector3) _paddleToBallVector;
    }
}
