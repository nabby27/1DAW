package H;


public class H {

    public static void main(String[] args) {
        int vector1[] = {3, 2};
        int vector2[] = {5, 4};
        int vector3[] = {-9, 3};

        Perimetro(vector1);
        Perimetro(vector2);
        Perimetro(vector3);
    }

    public static void Perimetro(int vector1[]) {
        int perimetro = 0;
        
         for (int i = 0; i < vector1.length; i++) {
            if (vector1[0] < 0 && vector1[1] < 0) {
                break;
            } else {
                perimetro += vector1[i] * 2;
            }
            if (i == 1 && vector1[0] > 0 && vector1[1] > 0) {
                   System.out.println(perimetro);
            }

        }
        
       

    }

}
