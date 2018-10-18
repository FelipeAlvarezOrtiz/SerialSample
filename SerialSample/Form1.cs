using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialSample
{
    //+569 44194679 me hablas al whathsapp si tienes alguna duda
    public partial class MainForm : Form
    {
        private string strBufferIn;
        private string strBufferOut;

        public MainForm()
        {
            InitializeComponent();
        }

        //Aqui Busca los puertos libres y los agrega al combobox
        private void resfreshClick(object sender, EventArgs e)
        {
            //Deshabilitamos el boton hasta detectar puertos compatibles
            connectButton.Enabled = false;
            //Limpiamos ComboBox y buscamos todos los nombres de los puertos disponibles
            cbSerials.Items.Clear();
            foreach (string puertoSingle in SerialPort.GetPortNames())
            {
                cbSerials.Items.Add(puertoSingle);

            }
            if (cbSerials.Items.Count > 0)
            {
                cbSerials.SelectedIndex = 0;
                connectButton.Enabled = true;
            }
            else
            {
                MessageBox.Show(this, "No hay puertos detectados", "Error");
                return;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Limpiamos los buffers
            strBufferIn = string.Empty;
            strBufferOut = string.Empty;
            connectButton.Enabled = false;

        }

        private void ConnectClick(object sender, EventArgs e)
        {
            string paridad = parityBox.Text;
            bool discardNull = checkBox1.Checked;

            try
            {
                //Puerto serial es nuestra variable SerialPort
                //Seteamos los baudrates haciendo un parse desde el combobox
                puertoSerial.BaudRate = Int32.Parse(baudCombo.Text);
                puertoSerial.PortName = cbSerials.Text;
                //Seteamos si se descartaran los Null
                puertoSerial.DiscardNull = discardNull ? true : false;
                //Aqui hay varias llaves según la paridad
                #region Paridad
                if (paridad.CompareTo("None") == 0)
                {
                    puertoSerial.Parity = Parity.None;
                }
                else if (paridad.CompareTo("Even") == 0)
                {
                    puertoSerial.Parity = Parity.Even;
                }
                else if (paridad.CompareTo("Mark") == 0)
                {
                    puertoSerial.Parity = Parity.Mark;
                }
                else if (paridad.CompareTo("Odd") == 0)
                {
                    puertoSerial.Parity = Parity.Odd;

                }
                else if (paridad.CompareTo("Space") == 0)
                {
                    puertoSerial.Parity = Parity.Space;
                }
                #endregion

                //seteamos los dataBits
                puertoSerial.DataBits = Int32.Parse(dataBitsBox.Text);
                //Seteamos los stopbits
                puertoSerial.StopBits = StopBits.One;
                //Seteamos si hay HandShake
                puertoSerial.Handshake = Handshake.None;
                //Abrimos el puerto
                try
                {
                    puertoSerial.Open();

                }
                catch (Exception)
                {
                    MessageBox.Show(this,"Error al abrir la comunación con el puerto","Error");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Error: " + error.Message, "Error");
            }
        }

        //Evento de data recibida, aquí si lo aplicas inmediatamente saltará un error
        //ya que intenta ingresar al form desde el puerto serial lo cual no esta permitido en .NET
        //La solución es crear un delegado y como parametro el ReadExisting, que es lo que venga desde
        //el puerto serial
        private void dataRecibida(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                textRecibidos.Text = string.Empty;
                textRecibidos.Text = puertoSerial.ReadExisting();

            }catch(InvalidOperationException messageError)
            {
                MessageBox.Show(this,"Error: "+messageError.Message,"Error");
            }
        }
    }
}
