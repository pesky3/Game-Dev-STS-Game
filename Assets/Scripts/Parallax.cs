using UnityEngine;

public class Parallax : MonoBehaviour
{
    public RectTransform[] layers;
    public float[] multiplier;
    public float dampSmoothTime = 1f;

    private Vector2[] initialPosition;
    private Vector2 startPoint;
    private Vector2 offset;
    private Vector2[] velocity;
    void Start()
    {
        startPoint = transform.position;
        velocity = new Vector2[layers.Length]; // these arrays need to have their "capacities filled" so that they aren't null when processed, leading to null reference errors
        initialPosition = new Vector2[layers.Length]; //in this piece of code it's probably better if the number was hard coded, but practicing soft coding implementation 

        for (int i = 0; i < layers.Length; i++)
        {
            initialPosition[i] = layers[i].anchoredPosition; //copying the values through Vector2 instead of RectTransform since Vector2 is a value type and not a class
        }
    }

    void Update()
    {
        offset = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        for (int i = 0; layers.Length > i; i++) 
        {
            layers[i].anchoredPosition = Vector2.SmoothDamp(layers[i].anchoredPosition, initialPosition[i] + offset * multiplier[i], ref velocity[i], dampSmoothTime);
        }
        // I am using anchoredPosition to move the images by the anchors instead of moving the anchors themselves, if i don't do this the images may get distorted
        // this is my first time using ref and I have learnt it's used for Unity to "remember" the value of velocity even after going through functions
    }
}
