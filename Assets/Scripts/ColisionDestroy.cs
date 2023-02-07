using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDestroy : MonoBehaviour
{
   public Inventario inventario;
   public float puntosDados;
   
    // Start is called before the first frame update
    void Start()
    {
       // onCollisionEnter();
       inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

   private void OnTriggerEnter(Collider other)
   {
      if (other.tag == "Player")
      {
         inventario.puntos += puntosDados;
         Destroy(gameObject);
      }
   }
   
}
