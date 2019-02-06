package ClasesJuntas;

public class Operario extends Empleado {

    private int telefono;

    public Operario() {
    }

    public Operario(String nombre) {
        super(nombre);
    }

    public Operario(String nombre, int telefono) {
        super(nombre);
        this.telefono = telefono;
    }

    public int getTelefono() {
        return this.telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    public String toString() {
        throw new UnsupportedOperationException("Not supported yet.");
    }
}
