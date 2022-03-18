using System.Text;  // Para Encoding
using System.Net.Sockets;    // Para NetworkStream
using S7.Net;
using Sharp7;

namespace InterfazImpresora
{
    public partial class Form1 : Form
    {
        private static readonly string ipImpr = "10.52.0.25";
        private static readonly int PuertoImp = 9100;
        private static readonly string ipPLC = "10.52.0.160";
        Plc plclab;
        //S7Client plcLab;
        TcpClient impresora;
        Stream stream;
        int Empezar = 16;


        //TcpClient client =new TcpClient(serverIP, serverPort);
        //Stream stream = client.GetStream();

        public Form1()
        {
            try
            {
                plclab = new Plc(CpuType.S71200, ipPLC, 0, 1);
                plclab.Open();
                
                impresora = new TcpClient(ipImpr, PuertoImp);
                stream = impresora.GetStream();
                //Acción para deshabilitar botones de comando remoto cuando remoto.cheked =false

               

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexion" + ex.Message);
            }

            InitializeComponent();

            Thread hiloCodigos = new Thread(new ThreadStart(GenerarCodigo));
            hiloCodigos.Start();

            if (!chkRemoto.Checked)
            {
                Start.Enabled = false;
                btnStop.Enabled = false;
            }

            if (!chkAutomatico.Checked)
            {
                btnOrden.Enabled = false;
            }
            if (!chkManual.Checked)
            {
                btnMotorAtras.Enabled = false;
                btnMotorAdelante.Enabled = false;
            }

            plclab.Write("DB5.DBX4.2", false);


        }

        private void btnEnviarImp_Click(object sender, EventArgs e)
        {
            Byte[] data = Encoding.ASCII.GetBytes(txtInstruccionImp.Text);
            data[data.Length - 1] = 13;
            stream.Write(data, 0, data.Length);
        }

        private void btnConsultarImp_Click(object sender, EventArgs e)
        {
            Byte[] data = Encoding.ASCII.GetBytes(txtInstruccionImp.Text);
            data[data.Length - 1] = 13;
            stream.Write(data, 0, data.Length);

            data = new byte[256];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.ASCII.GetString(data, 0, bytes);
            txtRespuestaImp.Text = responseData;
        }

        private void btnCerrarImp_Click(object sender, EventArgs e)
        {
            stream.Close();
            impresora.Close();
        }

        private void btnEnviarPLC_Click(object sender, EventArgs e)
        {
            if (plclab.IsConnected)
            {
                bool uscita = (bool)plclab.Read("DB3.DBX0.1");
                //if (uscita.Equals(false))
                //{
                    plclab.Write("DB3.DBX0.1", true);
                    //plclab.Write("DB5.DBX6.0", "mul123456");
                //}
                txtRespuestaPLC.Text = uscita.ToString();

            }
            //var buffer = new byte[108];
            //plcLab.DBRead(2, 0, buffer.Length, buffer);
            //bool db2dbx80 = 


        }
        private void btnConsultarPLC_Click(object sender, EventArgs e)
        {
            // Creo que se puede borrar
        }

        private void btnCerrarPLC_Click(object sender, EventArgs e)
        {
            // Creo que se puede borrar
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (plclab.IsConnected)
            {
                bool uscita = (bool)plclab.Read("DB5.DBX4.0");
                if (uscita.Equals(false))
                {
                    plclab.Write("DB5.DBX4.0", true);//Control de comando Start
                    Thread.Sleep(1000);
                    plclab.Write("DB5.DBX4.0", false);
                }

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (plclab.IsConnected)
            {
                bool uscita = (bool)plclab.Read("DB5.DBX4.1");
                if (uscita.Equals(false))
                {
                    plclab.Write("DB5.DBX4.1", true);  //control de comando Stop
                    Thread.Sleep(1000);
                    plclab.Write("DB5.DBX4.1", false);
                }

            }
        }

        private void chkRemoto_Click(object sender, EventArgs e)
        {
            if (chkRemoto.Checked)
            {
                Start.Enabled = true;
                btnStop.Enabled = true;
                bool uscita = (bool)plclab.Read("DB5.DBX4.3"); // control estado remoto / local

                if (uscita.Equals(false))
                {
                    plclab.Write("DB5.DBX4.3", true);
                }

            }
            else
            {
                Start.Enabled = false;
                btnStop.Enabled = false;
                plclab.Write("DB5.DBX4.3", false);
            }
        }


        private void chkAutomatico_Click(object sender, EventArgs e)
        {
            if (chkAutomatico.Checked)
            {
                chkManual.Enabled = false;
                btnOrden.Enabled = true;
                bool uscita = (bool)plclab.Read("DB5.DBX4.4"); // control estado remoto / local

                if (uscita.Equals(false))
                {
                    plclab.Write("DB5.DBX4.4", true);
                }

            }
            else
            {
                Start.Enabled = false;
                btnStop.Enabled = false;
                btnOrden.Enabled = false;
                plclab.Write("DB5.DBX4.4", false);
                chkManual.Enabled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            bool uscita = (bool)plclab.Read("DB5.DBX4.2"); // control estado remoto / local

            if (uscita.Equals(false))
            {
                plclab.Write("DB5.DBX4.2", true);
            }
        }

        private void chkManual_Click(object sender, EventArgs e)
        {
            if (chkManual.Checked)
            {
                //Start.Enabled = true;
                chkAutomatico.Enabled = false;
                btnOrden.Enabled = false;
                plclab.Write("DB5.DBX4.2", false);
                btnMotorAtras.Enabled= true;
                btnMotorAdelante.Enabled= true;
                bool uscita = (bool)plclab.Read("DB5.DBX4.5"); // control estado  manual 

                if (uscita.Equals(false))
                {
                    plclab.Write("DB5.DBX4.5", true);
                }               
            }
            else
            {
                plclab.Write("DB5.DBX4.5", false);    
                chkAutomatico.Enabled = true;
                btnMotorAtras.Enabled = false;
                btnMotorAdelante.Enabled = false;
            }
        }

        private void btnMotorAtras_Click(object sender, EventArgs e)
        {
            bool uscita = (bool)plclab.Read("DB5.DBX5.3");
            if (uscita.Equals(false))
            {
                plclab.Write("DB5.DBX5.3", true);//Control de comando Motor Atras
                Thread.Sleep(3000);
                plclab.Write("DB5.DBX5.3", false);
            }
        }

        private void btnMotorAdelante_Click(object sender, EventArgs e)
        {
            bool uscita = (bool)plclab.Read("DB5.DBX5.2");
            if (uscita.Equals(false))
            {
                plclab.Write("DB5.DBX5.2", true);//Control de comando Motor Adelante
                Thread.Sleep(3000);
                plclab.Write("DB5.DBX5.2", false);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            bool uscita = (bool)plclab.Read("DB5.DBX4.7");
            if (uscita.Equals(false))
            {
                plclab.Write("DB5.DBX4.7", true);//Control de comando Motor Adelante
                Thread.Sleep(1000);
                plclab.Write("DB5.DBX4.7", false);
            }

        }
        private void GenerarCodigo ()
        {
            //while (true)
            //{
                String Taller = "Mul";
                int CodigoProducto = 16;
                String codigo = String.Empty;
                codigo = Taller + CodigoProducto.ToString() + String.Format("{0:00000000}", Empezar);
                txtCodigoImpreso.Text = codigo;
                /**/
                Byte[] data = Encoding.ASCII.GetBytes("^0?EX.");
                data[data.Length - 1] = 13;
                stream.Write(data, 0, data.Length);

                data = new byte[256];
                String responseData = String.Empty;
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.ASCII.GetString(data, 0, bytes);
                string[] estadoSensor = responseData.Split();

            //Byte[] values = S7.Net.Types.String.ToByteArray(codigo);
               // plclab.Write("DB5.DBX6.0", codigo);

                if (estadoSensor[1] == "1")
                {
                    plclab.Write("DB5.DBX4.6", true);
                    Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!ET"+codigo+".");
                    codigoImpresora[codigoImpresora.Length - 1] = 13;
                    stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                    Empezar++;
                }
                else
                {
                    plclab.Write("DB5.DBX4.6", false);
                }
           // }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            string estatus = btnOnOff.Text;
            if(estatus == "On")
            {
                Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!PO.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnOnOff.Text = "Off";
            }else if(estatus == "Off")
            {
                Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!PF.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnOnOff.Text = "On";
            }
        }

        private void btnOpenClose_Click(object sender, EventArgs e)
        {
            string estatus = btnOpenClose.Text;
            if (estatus == "Open")
            {
                Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!NO.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnOpenClose.Text = "Close";
            }
            else if (estatus == "Close")
            {
                Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!NC.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnOpenClose.Text = "Open";
            }
        }

        private void btnGoStop_Click(object sender, EventArgs e)
        {
            string estatus = btnGoStop.Text;
            if (estatus == "Go")
            {
                Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!GO.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnGoStop.Text = "Stop";
            }
            else if (estatus == "Stop")
            {
                Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!ST.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnGoStop.Text = "Go";
            }
        }
    }
    //todo: recordar que al cerrar la aplicación se debe llevar al estado de inicio remoto =false
}

