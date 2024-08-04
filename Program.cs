class Calculadora
{
    public void Somar(int x, int y){
        Console.WriteLine($"{x} + {y} = {x + y}");
    }    

    public void Potencia(int x, int y){
        double pot = Math.Pow(x, y);
        Console.WriteLine($"{x} ^ {y} = {pot}");
    }
}