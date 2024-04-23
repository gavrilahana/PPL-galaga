using Assets.Script.Bullet.Type;
using Assets.Script.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Bullet
{
    public class BulletFactory : MonoBehaviour
    {
        public GameObject DefaultBullet;
       
        public void BuildBullet(BulletType bulletType, Vector3 position)
        {
            IBullet bullet = CreateBullet(bulletType);            
            GameObject gameObject = (GameObject) Instantiate(DefaultBullet, position, Quaternion.identity);
            gameObject.GetComponent<Bullet>().SetBullet(bullet);            
        }
        private IBullet CreateBullet(BulletType bulletType)
        {
            switch (bulletType)
            {
                case BulletType.Normal:
                    {
                        return new NormalBullet();
                    }
                case BulletType.Fast:
                    {
                        return new FastBullet();
                    }      
            }
            return null;
        }
    }
    
}
