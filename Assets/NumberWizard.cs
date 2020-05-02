using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    //Variables de instancia
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    //void significa que la función no retorna nada
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        
        Debug.Log("Bienvenido al Mago Numérico @_@");
        Debug.Log("Elije un número y no me digas cuál es");
        Debug.Log("El número más alto que puedes elegir es " + max);
        Debug.Log("El más bajo es " + min);
        Debug.Log("Dime si tu nombre es más alto o más bajo que " + guess);
        Debug.Log("Push UP = Higher, Push Down = Lower, Push Enter = Correct guess");

        //We add one to the max
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //The number is higher
            
            //My new min is 500 (at the first question)
            min = guess;
            NextGuess();
         }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Soy un GENIO muajajaj");
            StartGame();
        }
    }

    void NextGuess()
    {
        //Now there is a new guess. max plus min divided by 2
        guess = (max + min) / 2;
        Debug.Log("¿Tu número es más alto o más bajo que " + guess + "?");
    }

}
