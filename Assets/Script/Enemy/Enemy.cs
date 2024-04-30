using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Enemy
{
    public class Enemy : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D col)
        {
            
            Rigidbody2D rb = col.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
               
                Destroy(col.gameObject);
            }

           
            Destroy(gameObject);
        }
    }
}
