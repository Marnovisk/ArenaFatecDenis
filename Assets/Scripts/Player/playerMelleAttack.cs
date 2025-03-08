using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMelleAttack : MonoBehaviour
{
    private Collider enemy;
    private bool canAttack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.E))
        {
            Debug.Log("Ataque");
            if(enemy)
                Destroy(enemy.gameObject);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrou na area de ataque");
         if (other.gameObject.tag != "Enemy") return;

        Debug.Log("Entrou Inimigos");
        enemy = other;
    }
}
