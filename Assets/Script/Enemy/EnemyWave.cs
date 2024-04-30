using Assets.Script.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Enemy
{
    public class EnemyWave : MonoBehaviour
    {
        private WaveType _waveType;
        private Vector3 _wavePosition;
        private readonly List<GameObject> _enemies = new List<GameObject>();

        public EnemyWave(WaveType waveType, float defaultEnemyYPosition)
        {
            _wavePosition = new Vector3(0f, defaultEnemyYPosition);
            _waveType = waveType;
        }

        public void RegisterEnemy(GameObject enemy)
        {
            _enemies.Add(enemy);
        }

        void Update()
        {
            if (_waveType == WaveType.Down)
            {
                MoveDown();
            }
        }

        private void MoveDown()
        {
            _wavePosition.y -= 0.01f; 
            transform.Translate(Vector3.down * 0.01f); 
        }

        public void DestroyWave()
        {
            foreach (GameObject enemy in _enemies)
            {
                if (enemy != null)
                    Destroy(enemy);
            }
            Destroy(gameObject); 
        }
    }
}

