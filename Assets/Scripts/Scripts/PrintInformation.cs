using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintInformation : MonoBehaviour
{
    Car porshe = new Car();
    Car reno = new Car();
    Car lambo = new Car("Lamborgini");
    Car gaz2109 = new Car("GAZ2109", 50, EnginType.Gasoline);

    Transport audi = new Transport();

    [SerializeField] Car gaz111;
    [SerializeField] List<Car> Cars;

    void Start() 
    {

        Transport.height = 50f;
        print(Transport.height);

        porshe.name = "Порше";
        porshe.horsePower = 300;
        porshe.enginType = EnginType.Gasoline;

        reno.name = "Рено";
        reno.horsePower = 200; 
        reno.enginType = EnginType.Disel;

        porshe.GetInfo(); 

    }
}
