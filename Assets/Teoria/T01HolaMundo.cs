using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T01HolaMundo : MonoBehaviour {
	
	// mi nombre
	string nombre = "Mario";

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Hola " + nombre);

		// Tipos de datos

		// Enteros; int

		int numero = 13;
		int numero2 = 34;
		int numero3 = 3444;

		// int numero = 13, numero2 = 34, numero = 3444;

		// Numeros reales: float -> Numeros decimales positivos y negativos

		float nDecimal = 3.237683712f;

		// Cadenas de texto: string

		string mensaje = "Hola caracola";

		// Valores lógicos: bool

		// true == verdadero

		// false == falso

		bool decision = false;

		Debug.Log (numero);
		Debug.Log (numero2);
		Debug.Log (numero3);
	}
	

}
