// Change text color
lColorTexto.ForeColor = Color.Red;

// Move to left
this.Location = new Point(Left - 10, Top);

// Move to right
this.Location = new Point(Left + 10, Top);

// Move up
this.Location = new Point(this.Left, this.Top - 10);

// Move down 
this.Location = new Point(this.Left, this.Top + 10);

// Center to screen
this.CenterToScreen();

// Position X of mouse
e.X

// Position Y of mouse
e.Y

// Mouse button
e.Button

// Keys
e.KeyCode
e.KeyChar
e.Alt
e.Control
e.Shift
e.KeyCode.Equals(Keys.Enter)

// Box Message
MessageBox.Show("Necesita introducir un número de inicio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

// Close 
Close()

// Set Font
label.Font = new Font("Microsoft Sans Serif", 8.25f,  FontStyle.Italic);
label.Font =  new Font(label.Font, FontStyle.Bold);

// Check state of radio button
rb.Checked

// Check state of check box
cb.Checked

// Change text to number
Int32.Parse(tb.Text); 

// Create random number (0 - 10)
Random rnd = new Random();
numRandom = rnd.Next(11);

// Hide and show component
tb.Hide();
tb.Show();

// Change size
this.Size = new Size(x, y);