using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleInterpolater : MonoBehaviour
{
    public MeshFilter meshFilter, openMesh, closedMesh;

    Vector3[] vertices, startVertices, targetVertices;
    
    [SerializeField] private Transform flameThrowerColliderBox;

    // Start is called before the first frame update
    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();

        vertices = meshFilter.mesh.vertices;
        
        targetVertices = closedMesh.sharedMesh.vertices;

        startVertices = openMesh.sharedMesh.vertices;
        
        int count = vertices.Length;

        for(int i=0;i<count;i++)
        {
            vertices[i] = startVertices[i];
        }
        
        meshFilter.mesh.vertices = vertices;
    }

    // Update is called once per frame
    void Update()
    {
        int count = vertices.Length;

        for(int i=0;i<count;i++)
        {
            if (Vector3.Distance(flameThrowerColliderBox.position, vertices[i]) < .1f)
            {
                vertices[i] = Vector3.Lerp(vertices[i], targetVertices[i], Time.deltaTime);
            }
        }
        meshFilter.mesh.vertices = vertices;
    }
}
