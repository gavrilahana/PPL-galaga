using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Enemy
{
    public abstract class EnemyFactory : MonoBehaviour
    {
        
        public abstract int TimeGenerate { get; }

        
        public abstract EnemyWave GenerateEnemy(float defaultEnemyYPosition);
    }
}

