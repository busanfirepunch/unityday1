using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour
{
    public int maxHp;
    public int currentHp;


    // Start is called before the first frame update
    private void Start()
    {
        currentHp = maxHp;

    }

    // Update is called once per frame
    public void Damage(int damage)
    {
        currentHp -= damage;
        if (currentHp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
