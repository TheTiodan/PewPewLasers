using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] float backGroundScrollSpeed = 0.5f;
    Material myMaterial;
    Vector2 offSet;

    private void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offSet = new Vector2(0f, backGroundScrollSpeed);
    }
    private void Update()
    {
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;
    }
}
