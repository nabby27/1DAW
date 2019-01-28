
public class Semaforo {

    private String estado = "Rojo";

    public String getEstado() {
        return estado;
    }

    public void cambiaEstado() {
        if (estado.equals("Rojo")) {
            estado = "Verde";
        } else {
            if (estado.equals("Amarillo")) {
                estado = "Rojo";
            } else {
                estado = "Amarillo";
            }
        }
    }
}
