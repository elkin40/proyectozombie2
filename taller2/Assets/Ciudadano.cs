using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano 
{
	string[] nombres = new  string[]
    {
        "camilo","jose","juan","fernando","miguel","andres","julian","santiago","wilian" ,
        "jaime","carlos","federico","victor","hector","anibal","jesus","josue","tomas","emanuel",
        "wendy ","pablo" };

	GameObject city;
	Color corte;
	int edad;

	public Ciudadano(Vector3 pos)
	{
		city = GameObject.CreatePrimitive (PrimitiveType.Cube);
		corte = Color.gray;
		city.GetComponent<Renderer> ().material.color = corte;
		edad = Random.Range (15, 101);		
		Debug .Log (imprimirnombre());
        city.transform.position += pos;
	}

    string imprimirnombre()
    {
        int i = Random.Range(0,20);
        string mensaje = "HOLA SOY" + nombres[i] + " Y TENGO" + edad + "AÑOS";
        return mensaje;
    }
}
