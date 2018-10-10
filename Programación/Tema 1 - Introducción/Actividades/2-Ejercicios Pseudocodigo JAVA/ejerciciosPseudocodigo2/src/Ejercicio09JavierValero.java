
public class Ejercicio09JavierValero {

    public static void main(String[] args) {
        int num, suma, producto;
        num = 20;
        suma = 0;
        producto = 1;
        for (int i = 0; i <= 20; i++) {
            suma = suma + num;
            producto = producto * num;
            num = num + 2;
        }
        System.out.println("La suma es " + suma);
        System.out.println("El producto es " + producto);
    }
}
