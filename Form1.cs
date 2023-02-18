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

    private void txtX1_TextChanged(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(txtX1.Text))
        {
            txtX1.Text = "";
        }
        else
        {
            if (txtX1.Text == "")
                punto1.X = 0;
            else
                punto1.X = float.Parse(txtX1.Text);
        }
    }

    private void txtY1_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtY1.Text))
        {
            txtY1.Text = "";
        }
        else
        {
            if (txtY1.Text == "")
                punto1.Y = 0;
            else
                punto1.Y = float.Parse(txtY1.Text);
        }
    }

    private void btnCrearRecta_Click(object sender, EventArgs e)
    {
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

        if (string.IsNullOrEmpty(txtX2.Text))
        {
            txtX2.Text = "";
        }
        else
        {
            if (txtX2.Text == "")
                punto2.X = 0;
            else
                punto2.X = float.Parse(txtX2.Text);
        }
    }

    private void txtY2_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtY2.Text))
        {
            txtY2.Text = "";
        }
        else
        {
            if (txtY2.Text == "")
                punto2.Y = 0;
            else
                punto2.Y = float.Parse(txtY2.Text);
        }
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
        lblResultado.Text = Recta.CalcularDistancia(punto1, punto2).ToString() + " unidad (es)";
    }

    private void btnPendienteRecta_Click(object sender, EventArgs e)
    {
        lblResultado.Text = Recta.CalcularPendiente(punto1, punto2); //Devuelve un string para poder representar la pendiente en forma racional (fraccion) en formato texto.
    }

    private void btnPuntoMedioRecta_Click(object sender, EventArgs e)
    {
        lblResultado.Text = Recta.CalcularPuntoMedio(punto1, punto2);
    }
}
