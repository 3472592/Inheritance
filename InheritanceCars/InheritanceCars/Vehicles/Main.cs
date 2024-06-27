using InheritanceCars.Vehicles.Brands.EV;

namespace InheritanceCars
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ShowEVS12_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile
                (@"C:\Users\16507\Desktop\C#Books\C#\Ch6\InheritanceCars\InheritanceCars\Images\EVSilviaS12.jpg");
            Nissan silviaS12 = new()
            {
                Name = "Silvia S12"
            };

            SilviaEVFullName.Text = silviaS12.Name;
            EVSilviaCreds.Text = silviaS12.CarCreds(4, "T9Engine");
        }

        private void ShowEVS13_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile
                (@"C:\Users\16507\Desktop\C#Books\C#\Ch6\InheritanceCars\InheritanceCars\Images\EVSilviaS13.jpg");
            Nissan silviaS13 = new()
            {
                Name = "Silvia S13"
            };
            SilviaEVFullName.Text = silviaS13.Name;
            EVSilviaCreds.Text = silviaS13.CarCreds(4, "T9Engine");
        }

        private void ShowEVS14_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile
                (@"C:\Users\16507\Desktop\C#Books\C#\Ch6\InheritanceCars\InheritanceCars\Images\EVSilviaS14.jpg");
            Nissan silviaS14 = new()
            {
                Name = "Silvia S14"
            };
            SilviaEVFullName.Text = silviaS14.Name;
            EVSilviaCreds.Text = silviaS14.CarCreds(4, "T9Engine");
        }

        private void ShowEVS15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile
                (@"C:\Users\16507\Desktop\C#Books\C#\Ch6\InheritanceCars\InheritanceCars\Images\EVSilviaS15.jpg");
            Nissan silviaS15 = new()
            {
                Name = "Silvia S15"
            };
            SilviaEVFullName.Text = silviaS15.Name;
            EVSilviaCreds.Text = silviaS15.CarCreds(4, "T9Engine");
        }
    }
}