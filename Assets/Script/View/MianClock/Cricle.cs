using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script.View.MianClock
{
    public class PaintCircle : MonoBehaviour
    {
        private static readonly Color DEFOULT_COLOR = Color.white;

        public void Draw(float radius = 10f, Color color = default(Color))
        {
            var x = 0f;
            var y = 0f;
            var z = 0f;
            Vector3 vector;
            Vector3[] vertices;
            var theta = 0f;
            //
            var obj = new GameObject("circle");
            obj.transform.parent = this.transform;
            //
            //Material material = new Material(Shader.Find("Particles/Additive"));
            Material material = new Material(Shader.Find("Sprites/Default"));
            material.SetColor("_Color", color);
            var renderer = obj.AddComponent<MeshRenderer>();
            renderer.material = material;

            var mesh = new Mesh();
            var n = 144;
            vertices = new Vector3[3 * n];
            int[] triangles = new int[3 * n];
            for (var i = 0; i < n; i++)
            {
                theta = 0.1f * Mathf.PI;
                x = 0;
                y = 0;
                z = 0;
                vector = new Vector3(x, y, z);
                vertices[0 + i * 3] = vector;

                theta = 2f * Mathf.PI * (i / (n * 1f));
                x = radius * Mathf.Cos(theta);
                y = radius * Mathf.Sin(theta);
                z = 0;
                vector = new Vector3(x, y, z);
                vertices[1 + i * 3] = vector;

                theta = 2f * Mathf.PI * ((i + 1) / (n * 1f));
                x = radius * Mathf.Cos(theta);
                y = radius * Mathf.Sin(theta);
                z = 0;
                vector = new Vector3(x, y, z);
                vertices[2 + i * 3] = vector;
                //
                triangles[0 + i * 3] = 0 + i * 3;
                triangles[1 + i * 3] = 1 + i * 3;
                triangles[2 + i * 3] = 2 + i * 3;
            }
            mesh.vertices = vertices;

            mesh.triangles = triangles;
            mesh.RecalculateNormals();
            //
            var filter = obj.AddComponent<MeshFilter>();
            filter.sharedMesh = mesh;
        }

        // Use this for initialization
        private void Start()
        {
            /*
            var x = 0f;
            var y = 0f;
            var z = 0f;
            Vector3 vector;
            Vector3[] vertices;
            var radius = 30;
            var theta = 0f;
            //
            var obj = new GameObject("circle");
            obj.transform.parent = this.transform;
            //
            //Material material = new Material(Shader.Find("Particles/Additive"));
            Material material = new Material(Shader.Find("Sprites/Default"));
            material.SetColor("_Color", Color.blue);
            var renderer = obj.AddComponent<MeshRenderer> ();
            renderer.material = material;

            var mesh = new Mesh ();
            var n = 144;
            vertices = new Vector3[3*n];
            int[] triangles = new int[3 * n];
            for (var i = 0; i < n; i++)
            {
                theta = 0.1f * Mathf.PI;
                x = 0;
                y = 0;
                z = 0;
                vector = new Vector3(x,y,z);
                vertices[0+i*3] = vector;

                theta = 2f * Mathf.PI * (i / (n * 1f));
                x = radius * Mathf.Cos(theta);
                y = radius * Mathf.Sin(theta);
                z = 0;
                vector = new Vector3(x,y,z);
                vertices[1+i*3] = vector;

                theta = 2f * Mathf.PI * ((i + 1) / (n * 1f));
                x = radius * Mathf.Cos(theta);
                y = radius * Mathf.Sin(theta);
                z = 0;
                vector = new Vector3(x,y,z);
                vertices[2+i*3] = vector;
                //
                triangles[0 + i * 3] = 0 + i * 3;
                triangles[1 + i * 3] = 1 + i * 3;
                triangles[2 + i * 3] = 2 + i * 3;
            }
            mesh.vertices = vertices;

            mesh.triangles = triangles;
            mesh.RecalculateNormals ();
            //
            var filter = obj.AddComponent<MeshFilter>();
            filter.sharedMesh = mesh;
            */
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}