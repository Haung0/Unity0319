using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public int maxHp;
    public int currentHp;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
    }

    public void Damge(int damge)
    {
        currentHp -= damge;
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
