using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie 
{
    string[] coolor = new string[]
    {
    "green","magenta","cyan"
        };


GameObject zombie;
Color color;

    

    public Zombie(Color kol, Vector3 pos)

    {
        zombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
        color = kol;
        zombie.GetComponent<Renderer>().material.color = color;
        zombie.transform.position -= pos;
    }


    string imprimirnombre()
    {
        int ip = Random.Range(0, 4);
        string mensajes = "HOLA SOY UN ZONBIE COLOR" + coolor [ip] ;
        return mensajes;
    }
}

//private void Start () 
	//{
		
	//}
	
	
	//private void Update () 
	//{
		
	//}
//}

