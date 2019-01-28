
import java.util.Scanner;

public class MainSemaforo {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        Semaforo s1 = new Semaforo();
        Semaforo s2 = new Semaforo();
        Semaforo s3 = new Semaforo();
        int op, semaforo_elegido;

        String menu[] = {"Mostrar estados", "Cambiar estado", "Salir"};

        do {
            for (int i = 0; i < menu.length; i++) {
                System.out.println(i + ". " + menu[i]);
            }
            System.out.println("Opción:");
            op = sc.nextInt();
            switch (op) {
                case 0:
                    System.out.println("Semaforo 1 " + s1.getEstado());
                    System.out.println("Semaforo 2 " + s2.getEstado());
                    System.out.println("Semaforo 3 " + s3.getEstado());
                    break;
                case 1:
                    do {
                        System.out.println("Elige Semaforo 1, 2 o 3");
                        semaforo_elegido = sc.nextInt();
                    } while (semaforo_elegido < 1 || semaforo_elegido > 3);
                    switch (semaforo_elegido) {
                        case 1:
                            s1.cambiaEstado();
                            break;
                        case 2:
                            s2.cambiaEstado();
                            break;
                        case 3:
                            s3.cambiaEstado();
                    }
                    break;
                case 2:
                    System.out.println("Adios");
                    break;
                default:
                    System.out.println("Opción incorrecta");
            }
        } while (op != 2);
    }

}
