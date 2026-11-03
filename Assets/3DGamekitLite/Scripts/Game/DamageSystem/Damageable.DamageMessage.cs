using UnityEngine;
using Gamekit3D;
{
    public partial class Damageable : MonoBehaviour
    {
        public struct DamageMessage
        {
            public MonoBehaviour damager;
            public int amount;
            public Vector3 direction;
            public Vector3 damageSource;
            public bool throwing;

            public bool stopCamera;
        }
    } 
    private void DealDamage()
    {
        Damageble.DamageMessage specificDamageMessage = new Damageble.DamageMessage()
        {
            amount = 1,
            damager = this,
            direction = Vector3.zero,
            damageSource = Vector3.zero,
            throwing = false,
            stopCamera = false, 
            ;


        };
}
