using UnityEngine;
using Gameit3D;
    

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        
        
        // now we can use specificDamageMessage as a variable and deal 1 damage
    
    
        
       
                
    
        
}
