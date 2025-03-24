using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public int maxHp = 10;  
    public int currentHp;  

    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;  
    }

  
    public void Damage(int damage)
    {
        Debug.Log("-");
        currentHp -= damage;  
        if (currentHp <= 0)
        {
            gameObject.SetActive(false);  
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}