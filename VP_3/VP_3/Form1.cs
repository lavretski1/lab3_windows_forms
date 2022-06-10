
using System.Xml.Serialization;

namespace VP_3
{
    public partial class Form1 : Form
    {
        private int _currentItemIndex = -1;
        private List<CarInfo> carInfos;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            carInfos = Program.cars;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var car = new CarInfo();
            car.Color = System.Drawing.ColorTranslator.ToHtml(System.Drawing.Color.Transparent);
            Program.cars.Add(car);
            if (Program.cars == carInfos)
            {
                listView1.Items.Add("New Car");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) 
            {
                _currentItemIndex = -1;
                var newItem = new CarInfo();
                newItem.Color = System.Drawing.ColorTranslator.ToHtml(System.Drawing.Color.Transparent);
                CarName.Text = newItem.Brand;
                ManufactureYear.Value = newItem.ManufactureYear;
                EngineNumber.Text = newItem.EngineNumber;
                BodyNumber.Text = newItem.BodyNumber;
                Color.BackColor = System.Drawing.ColorTranslator.FromHtml(newItem.Color);
                Numberplate.Text = newItem.NumberPlate;
                OwnerName.Text = newItem.OwnerName;
                button6.Enabled = false;
                button2.Enabled = false;
                return;
            }
            button6.Enabled = true;
            button2.Enabled = true;
            int itemIndex = listView1.SelectedIndices[0];
            _currentItemIndex = itemIndex;
            var item = carInfos[itemIndex];
            CarName.Text = item.Brand;
            ManufactureYear.Value = item.ManufactureYear;
            EngineNumber.Text = item.EngineNumber;
            BodyNumber.Text = item.BodyNumber;
            Color.BackColor = System.Drawing.ColorTranslator.FromHtml(item.Color);
            Numberplate.Text = item.NumberPlate;
            OwnerName.Text = item.OwnerName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentItemIndex == -1) 
            {
                return;
            }
            int itemIndex = listView1.SelectedIndices[0];
            var item = carInfos[itemIndex];
            item.Brand = CarName.Text;
            item.ManufactureYear = (int)ManufactureYear.Value;
            item.EngineNumber = EngineNumber.Text;
            item.BodyNumber = BodyNumber.Text;
            item.Color = System.Drawing.ColorTranslator.ToHtml(Color.BackColor);
            item.NumberPlate = Numberplate.Text;
            item.OwnerName = OwnerName.Text;
            if (!string.IsNullOrEmpty(Numberplate.Text) && !string.IsNullOrWhiteSpace(Numberplate.Text))
            {
                listView1.SelectedItems[0].Text = Numberplate.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_currentItemIndex == -1)
            {
                return;
            }
            carInfos.RemoveAt(_currentItemIndex);
            if (carInfos != Program.cars) 
            {
                Program.cars.Remove(carInfos[_currentItemIndex]);
            }
            listView1.Items.RemoveAt(_currentItemIndex);
        }

        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.Color = Color.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                Color.BackColor = MyDialog.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var filteredData =
                from car in Program.cars
                where (string.IsNullOrEmpty(CarName.Text) ? true : car.Brand == CarName.Text) &&

                    (ManufactureYear.Value == 0 ? true : car.ManufactureYear == (int)ManufactureYear.Value) &&

                    (string.IsNullOrEmpty(EngineNumber.Text) ? true : car.EngineNumber == EngineNumber.Text) &&

                    (string.IsNullOrEmpty(BodyNumber.Text) ? true : car.BodyNumber == BodyNumber.Text) &&

                    (Color.BackColor == System.Drawing.Color.Transparent ? true : System.Drawing.ColorTranslator.FromHtml(car.Color) == Color.BackColor) &&

                    (string.IsNullOrEmpty(Numberplate.Text) ? true : car.NumberPlate == Numberplate.Text) &&

                    (string.IsNullOrEmpty(OwnerName.Text) ? true : car.OwnerName == OwnerName.Text)

                select car;

            carInfos = new List<CarInfo>(filteredData);

            UpdateList();
        }

        private void UpdateList() 
        {
            listView1.Items.Clear();

            foreach (var car in carInfos)
            {
                if (!string.IsNullOrEmpty(car.NumberPlate) && !string.IsNullOrWhiteSpace(car.NumberPlate))
                {
                    listView1.Items.Add(car.NumberPlate);
                }
                else
                {
                    listView1.Items.Add("New Car Info");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carInfos = Program.cars;
            UpdateList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML file|*.xml";
            saveFileDialog.Title = "Save Cars Data As XML File";
            saveFileDialog.FileName = "CarsInfo.xml";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CarInfo>));
                        TextWriter textWriter = new StreamWriter(saveFileDialog.FileName);
                        serializer.Serialize(textWriter, Program.cars);
                        textWriter.Close();
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML file|*.xml";
            openFileDialog.Title = "Open Cars Info";
            openFileDialog.FileName = "CarsInfo.xml";

            DialogResult result = openFileDialog.ShowDialog();
            openFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && openFileDialog.FileName != "")
            {
                try
                {
                    if (openFileDialog.CheckPathExists)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CarInfo>));
                        TextReader textReader = new StreamReader(openFileDialog.OpenFile());
                        Program.cars = serializer.Deserialize(textReader) as List<CarInfo>;
                        textReader.Close();
                        carInfos = Program.cars;
                        UpdateList();
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Program.cars.Count() == 0) 
            {
                return;
            }
            var avg =
                (from car in Program.cars
                 select car.ManufactureYear).Average();
            var filteredData =
                from car in Program.cars
                where car.ManufactureYear > avg
                select car.OwnerName;
            var count = filteredData.Count();
            filteredData = filteredData.Distinct();
            string message = $"Quantity of cars: {count}" + "\n";
            foreach (var name in filteredData) 
            {
                message += name + "\n";
            }
            MessageBox.Show(message);
        }

        private void ManufactureYear_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}