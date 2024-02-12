using UnityEngine;

public class SphereCreator : MonoBehaviour
{
    public int numberOfSpheres;
    public GameObject spherePrefab;

    void Start()
    {
        // Create initial spheres
        for (int i = 0; i < numberOfSpheres; i++)
        {
            CreateSphere();
        }

        // Duplicate spheres at random positions
        for (int i = 0; i < numberOfSpheres; i++)
        {
            Instantiate(spherePrefab, new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f), Quaternion.identity);
            // Randomly color instantiated sphere
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            spherePrefab.GetComponent<Renderer>().material.color = randomColor;
        }
    }

    void CreateSphere()
    {
        Instantiate(spherePrefab, transform.position, Quaternion.identity);
    }
}
