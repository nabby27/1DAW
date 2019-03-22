package G;

public class Main {

    private static String Abec[] = {"B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z"};

    public static void main(String[] args) {
        String Mat[] = {"1234 BBB", "9999 BBZ", "9999 BBD"};
        SiguienteMatricula(Mat);
    }

    public static void SiguienteMatricula(String m[]) {
        int num;
        String aux = "";

        for (int x = 0; x < m.length; x++) {
            String part[] = m[x].split(" ");
            num = Integer.parseInt(part[0]);
            aux = part[1];
            if (num == 9999) {
                part[0] = "0000";
                for (int i = 0; x < part[1].length(); i++) {
                    if (part[1].substring(2, 3).equalsIgnoreCase("Z")) {
                        for (int j = 0; j < Abec.length; j++) {
                            if (part[1].substring(1, 2).equalsIgnoreCase(Abec[j]) && !part[1].substring(1, 2).equalsIgnoreCase("Z")) {
                                aux = part[1].charAt(0) + "";
                                aux += Abec[j + 1];
                                aux += Abec[0];
                                break;
                            } else {
                                if (part[1].substring(1, 2).equalsIgnoreCase(Abec[j]) && part[1].substring(1, 2).equalsIgnoreCase("Z")) {
                                    aux = Abec[j + 1];
                                    aux += Abec[0];
                                    aux += Abec[0];
                                    break;
                                }
                            }
                        }
                        break;
                    } else {
                        for (int k = 0; k < Abec.length; k++) {
                            if (part[1].substring(2, 3).equalsIgnoreCase(Abec[k])) {
                                aux = part[1].charAt(0) + "";
                                aux +=  part[1].charAt(1) + "";
                                aux += Abec[k+1];
                                break;
                            }
                        }
                    }
                    break;
                }

            } else {
                num++;
                part[0] = Integer.toString(num);
            }
            System.out.println(part[0] + " " + aux);
        }
        
        
    }
}
