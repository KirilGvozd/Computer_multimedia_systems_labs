using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{

    public MeshRenderer renderer;
    private float minX, maxX, minZ, maxZ;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        minX = renderer.bounds.min.x;
        maxX = renderer.bounds.max.x;
        minZ = renderer.bounds.min.z;
        maxZ = renderer.bounds.max.z;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GenerateSphere();
        }
    }

    void GenerateSphere()
    {
        float newX = Random.Range(minX, maxX);
        float newZ = Random.Range(minZ, maxZ);
        float newY = transform.position.y + 5;

        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(newX, newY, newZ);
        sphere.AddComponent<Rigidbody>();

        Renderer sphereRenderer = sphere.GetComponent<Renderer>();
        sphereRenderer.material.color = Random.ColorHSV();
    }
}