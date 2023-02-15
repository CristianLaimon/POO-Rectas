namespace forms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.lblPunto1 = new System.Windows.Forms.Label();
            this.btnCrearRecta = new System.Windows.Forms.Button();
            this.grpboxRecta = new System.Windows.Forms.GroupBox();
            this.lblLineaCreadaAviso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lblPunto2 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.grpboxOperaciones = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTituloResultados = new System.Windows.Forms.Label();
            this.lblPuntoMedioRecta = new System.Windows.Forms.Label();
            this.lblPendienteRecta = new System.Windows.Forms.Label();
            this.btnPuntoMedioRecta = new System.Windows.Forms.Button();
            this.btnPendienteRecta = new System.Windows.Forms.Button();
            this.btnDistanciaPuntos = new System.Windows.Forms.Button();
            this.lblDistanciaPuntos = new System.Windows.Forms.Label();
            this.grpboxRecta.SuspendLayout();
            this.grpboxOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPunto1
            // 
            this.lblPunto1.AutoSize = true;
            this.lblPunto1.Location = new System.Drawing.Point(15, 65);
            this.lblPunto1.Name = "lblPunto1";
            this.lblPunto1.Size = new System.Drawing.Size(58, 20);
            this.lblPunto1.TabIndex = 0;
            this.lblPunto1.Text = "Punto1:";
            this.lblPunto1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCrearRecta
            // 
            this.btnCrearRecta.Location = new System.Drawing.Point(15, 26);
            this.btnCrearRecta.Name = "btnCrearRecta";
            this.btnCrearRecta.Size = new System.Drawing.Size(116, 36);
            this.btnCrearRecta.TabIndex = 1;
            this.btnCrearRecta.Text = "Crear Recta";
            this.btnCrearRecta.UseVisualStyleBackColor = true;
            this.btnCrearRecta.Click += new System.EventHandler(this.btnCrearRecta_Click);
            // 
            // grpboxRecta
            // 
            this.grpboxRecta.Controls.Add(this.lblLineaCreadaAviso);
            this.grpboxRecta.Controls.Add(this.label1);
            this.grpboxRecta.Controls.Add(this.label2);
            this.grpboxRecta.Controls.Add(this.txtY2);
            this.grpboxRecta.Controls.Add(this.txtX2);
            this.grpboxRecta.Controls.Add(this.lblPunto2);
            this.grpboxRecta.Controls.Add(this.lblY1);
            this.grpboxRecta.Controls.Add(this.lblX1);
            this.grpboxRecta.Controls.Add(this.txtY1);
            this.grpboxRecta.Controls.Add(this.txtX1);
            this.grpboxRecta.Controls.Add(this.btnCrearRecta);
            this.grpboxRecta.Controls.Add(this.lblPunto1);
            this.grpboxRecta.Location = new System.Drawing.Point(12, 12);
            this.grpboxRecta.Name = "grpboxRecta";
            this.grpboxRecta.Size = new System.Drawing.Size(370, 259);
            this.grpboxRecta.TabIndex = 2;
            this.grpboxRecta.TabStop = false;
            this.grpboxRecta.Text = "Recta";
            this.grpboxRecta.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblLineaCreadaAviso
            // 
            this.lblLineaCreadaAviso.AutoSize = true;
            this.lblLineaCreadaAviso.Location = new System.Drawing.Point(94, 216);
            this.lblLineaCreadaAviso.Name = "lblLineaCreadaAviso";
            this.lblLineaCreadaAviso.Size = new System.Drawing.Size(173, 20);
            this.lblLineaCreadaAviso.TabIndex = 12;
            this.lblLineaCreadaAviso.Text = "TextoPruebaLineaCreada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "X:";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(219, 165);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(125, 27);
            this.txtY2.TabIndex = 9;
            this.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtY2.TextChanged += new System.EventHandler(this.txtY2_TextChanged);
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(42, 165);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(125, 27);
            this.txtX2.TabIndex = 8;
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtX2.TextChanged += new System.EventHandler(this.txtX2_TextChanged);
            // 
            // lblPunto2
            // 
            this.lblPunto2.AutoSize = true;
            this.lblPunto2.Location = new System.Drawing.Point(15, 137);
            this.lblPunto2.Name = "lblPunto2";
            this.lblPunto2.Size = new System.Drawing.Size(62, 20);
            this.lblPunto2.TabIndex = 7;
            this.lblPunto2.Text = "Punto 2:";
            this.lblPunto2.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(193, 96);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(20, 20);
            this.lblY1.TabIndex = 6;
            this.lblY1.Text = "Y:";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(15, 96);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(21, 20);
            this.lblX1.TabIndex = 5;
            this.lblX1.Text = "X:";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(219, 93);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(125, 27);
            this.txtY1.TabIndex = 4;
            this.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtY1.TextChanged += new System.EventHandler(this.txtY1_TextChanged);
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(42, 93);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(125, 27);
            this.txtX1.TabIndex = 3;
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtX1.TextChanged += new System.EventHandler(this.txtX1_TextChanged);
            // 
            // grpboxOperaciones
            // 
            this.grpboxOperaciones.Controls.Add(this.lblResultado);
            this.grpboxOperaciones.Controls.Add(this.lblTituloResultados);
            this.grpboxOperaciones.Controls.Add(this.lblPuntoMedioRecta);
            this.grpboxOperaciones.Controls.Add(this.lblPendienteRecta);
            this.grpboxOperaciones.Controls.Add(this.btnPuntoMedioRecta);
            this.grpboxOperaciones.Controls.Add(this.btnPendienteRecta);
            this.grpboxOperaciones.Controls.Add(this.btnDistanciaPuntos);
            this.grpboxOperaciones.Controls.Add(this.lblDistanciaPuntos);
            this.grpboxOperaciones.Location = new System.Drawing.Point(421, 12);
            this.grpboxOperaciones.Name = "grpboxOperaciones";
            this.grpboxOperaciones.Size = new System.Drawing.Size(330, 393);
            this.grpboxOperaciones.TabIndex = 3;
            this.grpboxOperaciones.TabStop = false;
            this.grpboxOperaciones.Text = "Operaciones";
            this.grpboxOperaciones.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(138, 264);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(93, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "--------------";
            // 
            // lblTituloResultados
            // 
            this.lblTituloResultados.AutoSize = true;
            this.lblTituloResultados.Location = new System.Drawing.Point(115, 230);
            this.lblTituloResultados.Name = "lblTituloResultados";
            this.lblTituloResultados.Size = new System.Drawing.Size(78, 20);
            this.lblTituloResultados.TabIndex = 4;
            this.lblTituloResultados.Text = "Resultado:";
            // 
            // lblPuntoMedioRecta
            // 
            this.lblPuntoMedioRecta.AutoSize = true;
            this.lblPuntoMedioRecta.Location = new System.Drawing.Point(129, 172);
            this.lblPuntoMedioRecta.Name = "lblPuntoMedioRecta";
            this.lblPuntoMedioRecta.Size = new System.Drawing.Size(180, 20);
            this.lblPuntoMedioRecta.TabIndex = 5;
            this.lblPuntoMedioRecta.Text = "Punto medio de una recta";
            // 
            // lblPendienteRecta
            // 
            this.lblPendienteRecta.AutoSize = true;
            this.lblPendienteRecta.Location = new System.Drawing.Point(129, 118);
            this.lblPendienteRecta.Name = "lblPendienteRecta";
            this.lblPendienteRecta.Size = new System.Drawing.Size(160, 20);
            this.lblPendienteRecta.TabIndex = 4;
            this.lblPendienteRecta.Text = "Pendiente de una recta";
            // 
            // btnPuntoMedioRecta
            // 
            this.btnPuntoMedioRecta.Location = new System.Drawing.Point(20, 168);
            this.btnPuntoMedioRecta.Name = "btnPuntoMedioRecta";
            this.btnPuntoMedioRecta.Size = new System.Drawing.Size(94, 29);
            this.btnPuntoMedioRecta.TabIndex = 3;
            this.btnPuntoMedioRecta.Text = "Calcular";
            this.btnPuntoMedioRecta.UseVisualStyleBackColor = true;
            // 
            // btnPendienteRecta
            // 
            this.btnPendienteRecta.Location = new System.Drawing.Point(20, 114);
            this.btnPendienteRecta.Name = "btnPendienteRecta";
            this.btnPendienteRecta.Size = new System.Drawing.Size(94, 29);
            this.btnPendienteRecta.TabIndex = 2;
            this.btnPendienteRecta.Text = "Calcular";
            this.btnPendienteRecta.UseVisualStyleBackColor = true;
            this.btnPendienteRecta.Click += new System.EventHandler(this.btnPendienteRecta_Click);
            // 
            // btnDistanciaPuntos
            // 
            this.btnDistanciaPuntos.Location = new System.Drawing.Point(20, 56);
            this.btnDistanciaPuntos.Name = "btnDistanciaPuntos";
            this.btnDistanciaPuntos.Size = new System.Drawing.Size(94, 29);
            this.btnDistanciaPuntos.TabIndex = 1;
            this.btnDistanciaPuntos.Text = "Calcular";
            this.btnDistanciaPuntos.UseVisualStyleBackColor = true;
            this.btnDistanciaPuntos.Click += new System.EventHandler(this.btnDistanciaPuntos_Click);
            // 
            // lblDistanciaPuntos
            // 
            this.lblDistanciaPuntos.AutoSize = true;
            this.lblDistanciaPuntos.Location = new System.Drawing.Point(129, 60);
            this.lblDistanciaPuntos.Name = "lblDistanciaPuntos";
            this.lblDistanciaPuntos.Size = new System.Drawing.Size(185, 20);
            this.lblDistanciaPuntos.TabIndex = 0;
            this.lblDistanciaPuntos.Text = "Distancia entre dos puntos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpboxOperaciones);
            this.Controls.Add(this.grpboxRecta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxRecta.ResumeLayout(false);
            this.grpboxRecta.PerformLayout();
            this.grpboxOperaciones.ResumeLayout(false);
            this.grpboxOperaciones.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Label lblPunto1;
    private Button btnCrearRecta;
    private GroupBox grpboxRecta;
    private Label label1;
    private Label label2;
    private TextBox txtY2;
    private TextBox txtX2;
    private Label lblPunto2;
    private Label lblY1;
    private Label lblX1;
    private TextBox txtY1;
    private TextBox txtX1;
    private Label lblLineaCreadaAviso;
    private GroupBox grpboxOperaciones;
    private Label lblDistanciaPuntos;
    private Label lblResultado;
    private Label lblTituloResultados;
    private Label lblPuntoMedioRecta;
    private Label lblPendienteRecta;
    private Button btnPuntoMedioRecta;
    private Button btnPendienteRecta;
    private Button btnDistanciaPuntos;
}
