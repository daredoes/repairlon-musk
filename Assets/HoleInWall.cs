using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleInWall : MonoBehaviour
{
    MeshFilter meshFilter;

    // Start is called before the first frame update
    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();

        Vector3[] vertices = meshFilter.mesh.vertices;

        int count = vertices.Length;

        for(int i=0;i<count;i++)
        {
        Debug.Log("vertices["+i+"] = "+vertices[i]);
            vertices[i] += new Vector3(
                Random.value * .001f,
                Random.value * .001f,
                Random.value * .001f
                );
        }
        meshFilter.mesh.vertices = vertices;
        meshFilter.mesh.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
