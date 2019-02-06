package ClasesJuntas;

public class Oficial extends Operario {

    public Oficial() {
    }

    public Oficial(String nombre) {
        super(nombre);
    }

    public Oficial(String nombre, int telefono) {
        super(nombre, telefono);
    }

    public String toString() {
        throw new UnsupportedOperationException("Not supported yet.");
    }
}
