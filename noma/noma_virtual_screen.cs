using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noma {

    // Custom class for manipulating the virtual screen
    public class noma_virtual_screen {

        // Creating instances of virtual screen width and height and it's location
        public int virtual_screen_height = 250;
        public int virtual_screen_width;
        public int virtual_screen_loc_x;
        public int virtual_screen_loc_y;

        // Creating the instances of the cursor location
        public int virtual_screen_cursor_loc_x;
        public int virtual_screen_cursor_loc_y;

        // Creating the new screen
        public noma_virtual_screen(int virtual_screen_loca_x, int virtual_screen_loca_y) {

            // Getting the size of screen and resizing the mouse display box
            int screen_height = Screen.PrimaryScreen.Bounds.Height,
                screen_width = Screen.PrimaryScreen.Bounds.Width;

            // Calculating the virtual screen width
            float screen_height_dif = (float)screen_height / (float)virtual_screen_height;
            float virtual_screen_width_calc = (float)screen_width / (float)screen_height_dif;

            // Applying the screen width
            virtual_screen_width = (int)virtual_screen_width_calc;

            virtual_screen_loc_x = virtual_screen_loca_x;
            virtual_screen_loc_y = virtual_screen_loca_y;

            // When the instance is created, create new panel in that location
            Panel virtual_screen_background = new Panel();
            Panel virtual_screen_cursor = new Panel();

            // Setting the colour
            virtual_screen_background.BackColor = Color.Black;
            virtual_screen_cursor.BackColor = Color.Aquamarine;

            // Setting the location of screen
            virtual_screen_background.Location = new Point(virtual_screen_loc_x, virtual_screen_loc_x);

            // Setting the height and width of screen
            virtual_screen_background.Height = virtual_screen_height;
            virtual_screen_background.Width = virtual_screen_width;

            // Setting the location of the cursor
            virtual_screen_cursor.Location = new Point(virtual_screen_loc_x, virtual_screen_loc_x);

        }

    }

}
