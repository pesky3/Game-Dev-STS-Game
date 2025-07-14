using UnityEngine;

public class Parallax : MonoBehaviour
{
    public RectTransform[] layers;
    public float[] multiplier;
    public float dampSmoothTime = 1f;

    private Vector2 startPoint;
    private Vector2 offset;
    private Vector2 velocity;
    void Start()
    {
        startPoint = transform.position;
    }

    void Update()
    {
        offset = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        for (int i = 0; layers.Length > i; i++) 
        {
            layers[i].anchoredPosition = Vector2.SmoothDamp(layers[i].anchoredPosition, offset * multiplier[i], ref velocity, dampSmoothTime);
        }
        // I am using anchoredPosition to move the images by the anchors instead of moving the anchors themselves, if i don't do this the images may get distorted
        // this is my first time using ref and I have learnt it's used for Unity to "remember" the value of velocity even after going through functions
    }
}
