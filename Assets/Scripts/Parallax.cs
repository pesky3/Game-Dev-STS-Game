using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float multiplier = 1f;
    public float dampSmoothTime = 1f;

    private Vector2 startPoint;
    private Vector2 offset;
    void Start()
    {
        startPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        offset = Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }
}
