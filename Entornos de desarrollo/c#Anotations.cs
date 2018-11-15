// Cambiar color texto
lColorTexto.ForeColor = Color.Red;

// Mover a la izquierda
this.Location = new Point(Left - 10, Top);

// Mover a la izquierda
this.Location = new Point(Left + 10, Top);

// Mover hacía arriba
this.Location = new Point(this.Left, this.Top - 10);

// Mover hacía abajo 
this.Location = new Point(this.Left, this.Top + 10);

// Centrar a la pantalla
this.CenterToScreen();

// Posicion X del raton
e.X

// Posicion Y del raton
e.Y

// Boton del ratón
e.Button

// Tecla apretada
e.KeyCode
e.KeyChar
e.Alt
e.Control
e.Shift
e.KeyCode.Equals(Keys.Enter)

// Mensage en box
MessageBox.Show("Necesita introducir un número de inicio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

// Cerrar 
Close()

// Set Font
label.Font = new Font("Microsoft Sans Serif", 8.25f,  FontStyle.Italic);
label.Font =  new Font(label.Font, FontStyle.Bold);

// Comprobar estado de radio button
rb.Checked

// Comprobar estado de check box
cb.Checked

// Convertir texto a número
Int32.Parse(tb.Text); 

// Crear número random de 0 a 10
Random rnd = new Random();
numRandom = rnd.Next(11);

// Ocultar y mostrar un componente
tb.Hide();
tb.Show();

// Cambiar tamaño
this.Size = new Size(x, y);