using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleInWall : MonoBehaviour
{
    MeshFilter meshFilter;
    
    [SerializeField] private Transform flameThrowerColiderBox;
    
    Vector3[] startVertices, vertices;

    public Transform closestPointIndicator, impactPoint;

    public MeshFilter openMesh, closedMesh;
    
    // Start is called before the first frame update
    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();

        startVertices = meshFilter.mesh.vertices;

        vertices = meshFilter.mesh.vertices;
        
        Impact();
    }

    void Randomize()
    {
        
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



    void Impact()
    {
        int count = vertices.Length;

        for(int i=0;i<count;i++)
        {
            float pointDistance = Vector3.Distance(
                GetVertexWorldPosition(vertices[i], transform), 
                impactPoint.position
                );

            vertices[i] += new Vector3(
                (GetVertexWorldPosition(vertices[i], transform).x - impactPoint.position.x) / 10f, 
                0, 
                .1f/pointDistance*Time.deltaTime
                ); // (GetVertexWorldPosition(vertices[i], transform) - impactPoint.position) / 2f * .01f/pointDistance; //
        }
        
        meshFilter.mesh.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {
        int count = startVertices.Length;

        int closestPointIndex = 0;
        float closestPointDistance = Vector3.Distance(startVertices[0], flameThrowerColiderBox.position);

        for( int i=0 ; i < count ; i++ )
        {
            float pointDistance = Vector3.Distance(
                GetVertexWorldPosition(vertices[i], transform), 
                flameThrowerColiderBox.position
                );

            if ( pointDistance < closestPointDistance )
            {
                closestPointDistance = pointDistance;
                closestPointIndex = i;
            }
            
            Debug.Log("pointDistance = "+pointDistance);
            
            if (pointDistance < .1f)
            {
                vertices[i] += new Vector3(0, 0, -.001f/pointDistance*Time.deltaTime);
            }
        }

        closestPointIndicator.position = GetVertexWorldPosition(vertices[closestPointIndex], transform);
        
        meshFilter.mesh.vertices = vertices;
    }

    public Vector3 GetVertexWorldPosition(Vector3 vertex, Transform owner)
    {
        return owner.localToWorldMatrix.MultiplyPoint3x4(vertex);
    }
}
