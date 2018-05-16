using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manaqer : MonoBehaviour 
{

    private void Start()
    {
        Vector3 pos = new Vector3();
        pos = posicion();
        Heroe heroe = new Heroe(Color.blue);

       // Zombie z = new Zombie(Color.magenta, pos);


        int color;
        
        color = (Random.Range(1, 4));

        switch (color)
        {
            case 1:
                Zombie p = new Zombie(Color.magenta,pos);
                break;
            case 2:
                Zombie x = new Zombie(Color.green, pos);
                break;
            case 3:
                Zombie z = new Zombie(Color.cyan, pos);
                break;
           
        }
         




Ciudadano c = new Ciudadano (pos);

        
        
	}


    Vector3 posicion()
    {
        Vector3 pos;
        //pos = new Vector3();
        pos.x = Random.Range(-10,10);
        pos.y = 0f;
        pos.z = Random.Range(-10, 10);
        return pos;

    }

	private void Update () 
	{
		
	}
}
