using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GameObject sphere = collision.collider.gameObject;
        Color sphereColor = sphere.GetComponent<Renderer>().material.color;
        // Change cube color to sphere color
        GetComponent<Renderer>().material.color = sphereColor;
    }
}
