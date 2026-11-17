using UnityEngine;
using Gamekit3D;


public class HungerManager : MonoBehaviour
{
    private Damageable damageTarget;
    
    // timers
    [SerializeField] private float damageTime = 15.0f;
    private float timer = 0.0f;
    
    //damage
    [SerializeField] private int damageAmount = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damageTarget = GameObject.Find("Ellen").GetComponent<Damageable>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 
        
        
        if (timer >= damageTime)
        {
            Damageable.DamageMessage msg = new Damageable.DamageMessage
            {
                damager = this,
                amount = damageAmount,
                damageSource = new Vector3(x:0,y:0,z:0).normalized,
                direction = new Vector3(x:0,y:0,z:0) .normalized,
                throwing = false,
                stopCamera = false
            };
            
            
          damageTarget.ApplyDamage(msg);
          ResetTimer();
            
        }
            
    }
    
    public void ResetTimer()
    {
        timer = 0.0f;
        
    }
}
