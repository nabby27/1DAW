
import java.util.ArrayList;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Agenda {
    
    private int maximo;
    private ArrayList<Contacto> lista = new ArrayList<Contacto>();

    public Agenda() {
    }

    public Agenda(int maximo) {
        this.maximo = maximo;
    }

    public ArrayList<Contacto> getLista() {
        return lista;
    }

    public void addLista(Contacto contacto) {
        this.lista.add(contacto);
    }
    
    public boolean isLimiteContactos() {
        return maximo <= lista.size();
    }
    
}
