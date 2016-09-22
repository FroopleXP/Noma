using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace noma
{
    public partial class noma_main_form : Form
    {

        // Creating an array of the available baud rate
        int[] baud_rates_arr = { 9600, 115200 };

        public noma_main_form()
        {   

            // Rendering the form
            InitializeComponent();

            // Getting the available serial ports
            string[] ports = SerialPort.GetPortNames();

            // Checking if there are any ports
            if (ports.Length > 0) {
                // There are ports available... Populate the combobox
                foreach (string port in ports) {
                    noma_com_port.Items.Add(port);
                }    

            } else {
                // No ports are available
                MessageBox.Show("No ports are available!");
                noma_com_port.Items.Add("No ports available!");
            }

            // Populating the baud select box
            foreach (int rate in baud_rates_arr) {
                noma_com_baud.Items.Add(rate);
            }

        }

        // Used to connect to the COM port
        private void connect_to_port (string port_name, int baud) {

            // Setting up the serial connection
            noma_serial_port.BaudRate = baud;
            noma_serial_port.PortName = port_name;

            // Checking that the port isn't already in use
            if (!noma_serial_port.IsOpen) {

                try {

                    // It's not, let's try to open it
                    noma_serial_port.Open();

                    MessageBox.Show("Connected!");

                } catch (InvalidCastException e) {
                    // Failed to connect to the COM port
                    MessageBox.Show("Failed to open COM port!");
                    MessageBox.Show(e.Data.ToString());

                }

            } else {
                // Port is already in use
                MessageBox.Show("Port is already in use!");
            }
            

        }

        // Creating a custom void to control the mouse
        private void move_mouse (int mouse_x, int mouse_y)
        {
            // Moving the mouse
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point(mouse_x, mouse_y);

        }

        // Listening for click on mouse move button
        private void button1_Click(object sender, EventArgs e)
        {

            // Declaring the X and Y
            int mouse_x,
                mouse_y;

            // Getting the X and Y values and trying to parse as int
            bool mouse_to_x = int.TryParse(noma_mouse_x.Text, out mouse_x),
                mouse_to_y = int.TryParse(noma_mouse_y.Text, out mouse_y);

            // Checking that the parse was successful
            if (mouse_to_x && mouse_to_y == true) {
                move_mouse(mouse_x, mouse_y);
            } else {
                MessageBox.Show("You must only enter number!");
            }

        }

        // Listening for a click on the connect button
        private void noma_com_connect_Click(object sender, EventArgs e) {

            // Getting the baud and com port to connect to
            string port = noma_com_port.Text;
            int baud = int.Parse(noma_com_baud.Text);

            // Connecting
            connect_to_port(port, baud);

        }

    }
}
