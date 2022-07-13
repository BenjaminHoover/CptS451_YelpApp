using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CptS451WinFormsApp
{
    public class Business
    {
        public string id;
        public string Name;
        public string address;
        public string city;
        public string state;
        public string postal_code;

        public bool isOpen;

        public int num_tips;
        public int num_checkins;

        public double stars;
        public double latitude;
        public double longitude;

        public Business() //Default Constructor
        {
            Name = "\0";
            address = "\0";
            city = "\0";
            state = "\0";
            postal_code = "\0";

            isOpen = false;

            num_tips = 0;
            num_checkins = 0;

            stars = 0;
            latitude = -1;
            longitude = -1;
        }

        public Business(string n, string ad, string c, string s, string p_c, bool isOp, int n_t, int n_c, double star, double lat, double lon) //Full Constructor
        {
            Name = n;
            address = ad;
            city = c;
            state = s;
            postal_code = p_c;

            isOpen = isOp;

            num_tips = n_t;
            num_checkins = n_c;

            stars = star;
            latitude = lat;
            longitude = lon;
        }

        public Business(string n, string c, string s, bool isOp, int n_t, int n_c, double star) //Partial Constructor (Only INFO needed for LiveCharts)
        {
            Name = n;
            address = "\0";
            city = c;
            state = s;
            postal_code = "\0";

            isOpen = isOp;

            num_tips = n_t;
            num_checkins = n_c;

            stars = star;
            latitude = -1;
            longitude = -1;
        }
    }
}
