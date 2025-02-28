using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "ScriptableObjects/EnemyData", order = 0)]
public class EnemyScriptable : ScriptableObject
{
   [Header("Travel Data")]
   public float speed;

   [Header("Health Data")]
   public float health;

   [Header("Kombat Data")]
   public float AttackRange;
   public float AttackSpeed;
   public int[] AttackDamage;
    

   [Header("Data")]
   public GameObject GFX;
}
