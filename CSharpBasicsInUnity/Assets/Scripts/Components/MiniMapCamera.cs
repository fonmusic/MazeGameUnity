using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCamera : MonoBehaviour
{
    public Shader _replaceShader;
    private Camera MapCamera;

    private void Awake()
    {
        MapCamera = GetComponent<Camera>();
        _replaceShader = Shader.Find("Unlit/Texture");
        if (_replaceShader)
        {
            MapCamera.SetReplacementShader(_replaceShader, "RenderType");
        }
    }

    private void OnDisable()
    {
        MapCamera.ResetReplacementShader();
    }
}
