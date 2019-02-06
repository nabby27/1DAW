package ClasesJuntas;

public class Tecnico extends Operario {

    public Tecnico() {
    }

    public Tecnico(String nombre) {
        super(nombre);
    }

    public Tecnico(String nombre, int telefono) {
        super(nombre, telefono);
    }

    public String toString() {
        throw new UnsupportedOperationException("Not supported yet.");
    }
}
