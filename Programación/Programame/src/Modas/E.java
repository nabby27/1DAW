package E;


public class E {

    public static void main(String[] args) {
        int vector1[] =  {1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5};
        int vector2[] ={1, 8, 9, 6, 3, 2, 1, 5, 4, 7, 9, 6, 3, 2, 1, 4, 7};
        int contador[] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int contador2[] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        
        contar(vector1, contador);
        contar(vector2, contador2);

    }
    
    public static void contar(int vector1[], int contador[]) {
          int mayor = 0;
        int num = vector1[0];
        for (int i = 0; i < vector1.length; i++) {
            for (int j = 0; j < vector1.length; j++) {
                if (vector1[i] == vector1[j]) {
                    contador[i]++;
                    
                }

                if (contador[i] > mayor) {
                    mayor = contador[i];
                    num = vector1[i];

                }
            }

        }
        System.out.println(num);
    }
}
