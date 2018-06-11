using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGeneratorController : MonoBehaviour {


    public GameObject enemyPrefab;
    public float tiempoGeneracion = 1.75f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateEnemy(){
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }

    public void ComenzarGeneracionEnemigo(){
        InvokeRepeating("CreateEnemy", 0f, tiempoGeneracion);
    }

    public void TerminarGeneracionEnemigo(bool limpiar = false)
    {
        CancelInvoke("CreateEnemy");
        if(limpiar){
            object[] todosEnemigos = GameObject.FindGameObjectsWithTag("Enemigo");
            foreach(GameObject enemigo in todosEnemigos){
                Destroy(enemigo);
            }

        }
    }
}
