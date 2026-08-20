using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform startPos;
    [SerializeField] private Transform targetPos;


    public List<Transform> points;

    [Range(0f,1f)]
    public float value = 0;
    public float speed = 0.1f;
    public int index = 0;

    [SerializeField] private bool start = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (value >= 1 || startPos == null)
        {

            startPos = points[index];
            targetPos = points[index + 1];
            value = 0;
            index++;
        }
        else
        {
            value += speed * Time.deltaTime;
            Vector3 newPosition = Vector3.Lerp(startPos.position,targetPos.position,value);
        
            transform.position = newPosition;
        }


        
    }
}
