using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GladiatorController : MonoBehaviour
{
    [Header("MainData")]
    [SerializeField] private EnemyScriptable brain;
    [Header("TransformData")]
    [SerializeField] private Transform GFXTransform;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateGraphics();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiateGraphics()
    {
        var gfx = Instantiate(brain.GFX, GFXTransform);
        gfx.transform.parent = this.transform; 
    }
}
