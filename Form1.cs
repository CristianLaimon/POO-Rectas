namespace forms;

public partial class Form1 : Form
{
    Punto punto1 = new Punto();
    Punto punto2 = new Punto();
    Recta rectaUsuario = new Recta();
    
    public Form1()
    {
        InitializeComponent();
    }
 
    private void btnCrearRecta_Click(object sender, EventArgs e)
    {

        punto1.X = (float)numX1.Value;
        punto1.Y = (float)numY1.Value;

        punto2.X = (float)numX2.Value;
        punto2.Y = (float)numY2.Value;

        rectaUsuario.A = punto1;
        rectaUsuario.B = punto2;

        lblLineaCreadaAviso.Text = $"Punto A: ({punto1.X}, {punto1.Y}) Punto B: ({punto2.X}, {punto2.Y})";
    }


    private void label3_Click(object sender, EventArgs e)
    {

    }
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void txtX2_TextChanged(object sender, EventArgs e)
    {


    }

    private void txtY2_TextChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        lblLineaCreadaAviso.Text = "";
        lblResultado.Text = "";
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void btnDistanciaPuntos_Click(object sender, EventArgs e)
    {
        if (punto1.X == 0 && punto1.Y== 0 && punto2.X == 0 && punto2.Y == 0)
        {
            MessageBox.Show("No se ha creado una recta todavía o tiene coordenadas 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            lblResultado.Text = Recta.CalcularDistancia(punto1, punto2).ToString() + " unidad (es)";
        }
    }

    private void btnPendienteRecta_Click(object sender, EventArgs e)
    {
        if (punto1.X == 0 && punto1.Y == 0 && punto2.X == 0 && punto2.Y == 0)
        {
            MessageBox.Show("No se ha creado una recta todavía o tiene coordenadas 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            lblResultado.Text = Recta.CalcularPendiente(punto1, punto2); //Devuelve un string para poder representar la pendiente en forma racional (fraccion) en formato texto.
        }
    }

    private void btnPuntoMedioRecta_Click(object sender, EventArgs e)
    {
        if (punto1.X == 0 && punto1.Y == 0 && punto2.X == 0 && punto2.Y == 0)
        {
            MessageBox.Show("No se ha creado una recta todavía o tiene coordenadas 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            lblResultado.Text = Recta.CalcularPuntoMedio(punto1, punto2);

        }
    
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form2 ventanaEstudiante = Form2.INSTANCIA;
        ventanaEstudiante.Show();
        ventanaEstudiante.BringToFront();
    }
}
