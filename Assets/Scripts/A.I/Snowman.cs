using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    private int health;
    private void Awake() {
        health = 2;
    }
public bool damage(int damageValue)
    {
        health -= damageValue;
        if (health == 1) {
            takeDamage();
		} else if (health <= 0) {
            Destroy(gameObject);
            return true;
        }
        return false;
    }

    void takeDamage () {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
