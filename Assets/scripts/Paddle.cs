using UnityEngine;
using UnityEngine.UI;

public class Paddle : MonoBehaviour
{
    private CanvasScaler _canvasScaler;
    [SerializeField] private float paddleOffset;
    void Start() => _canvasScaler = GameObject.Find("Canvas").GetComponent<Canvas>().GetComponent<CanvasScaler>();

    // Update is called once per frame
    void Update()
    {
        var currentMouseX = Input.mousePosition.x;
        var cameraSize = (Camera.main?.orthographicSize ?? 1) * 2;
        var referenceResolution = _canvasScaler.referenceResolution;
        var currentScreenWidthInUnits = referenceResolution.x / referenceResolution.y * cameraSize;
        var transform1 = transform;
        var mousePos = currentMouseX / Screen.width * currentScreenWidthInUnits;
        var range = Mathf.Clamp(mousePos, 1.5f + paddleOffset, 14.5f - paddleOffset);
        transform1.position = new Vector2(range, transform1.position.y);
    }
}
