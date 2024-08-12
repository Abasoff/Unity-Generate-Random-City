using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBuild180Degree : MonoBehaviour
{
    public GameObject[] buildings;

    private void Start()
    {
        // Define the allowed angles
        float[] allowedAngles = { 180, -180 };

        // Select a random building from the array
        GameObject building = buildings[Random.Range(0, buildings.Length)];

        // Select a random angle from the allowed angles
        float randomAngle = allowedAngles[Random.Range(0, allowedAngles.Length)];

        // Define the rotation based on the selected angle
        Quaternion rotation = Quaternion.Euler(0, randomAngle, 0);

        // Instantiate the building with the chosen rotation
        Instantiate(building, transform.position, rotation);
    }
}
