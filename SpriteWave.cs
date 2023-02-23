using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteWave : MonoBehaviour
{
    [SerializeField]
    private Transform spriteTransform;

    [SerializeField]
    private float xOffset;

    [SerializeField]
    private float yPosition = -5f;

    [SerializeField]
    private float speed = 0.5f;

    [SerializeField]
    private float damper = 0.5f;

    [SerializeField]
    private float yIntercept = 0f;

    // Update is called once per frame
    void Update()
    { 
      yPosition += speed * Time.deltaTime;
      spriteTransform.position = new Vector2(0f + xOffset, (Mathf.Sin(yPosition)/damper) + yIntercept);
    }

}

