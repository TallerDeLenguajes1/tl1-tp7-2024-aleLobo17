using System.Dynamic;

namespace EspacioCalculadora;

public class calculadora
{
    private double dato;

    /*public double Dato{
        get;
        set;
    }
    */

    public double RESULTADO{ get => dato;}

    //dos opciones para hacer get de resultado
    public double RESULTADO2{
        get{
            return dato;
        }
    }
    
    public void Sumar(double termino){
        dato = dato+termino;
    }
    public void Restar(double termino){
        dato= dato-termino;
    }
    public void Multiplicar(double termino){
        dato= dato * termino;
        
    }
    public void Dividir(double termino){
        dato= dato / termino;
    }
    public void Limpiar(){
        dato = 0;
    }

}


