using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OutputAnalogVoltages
{
    public partial class Form1 : Form
    {   double AnalogV;
        NationalInstruments.DAQmx.Task analogOutTask = new NationalInstruments.DAQmx.Task(); //Creating a global task
        AnalogMultiChannelWriter writer;

        List<double> voltageslist = new List<double>(); //creating a new list (similar to an array but it is flexible)
        string[] ao_Channels;
        public Form1()
        {
            InitializeComponent();

            voltageslist.Add(0);
            voltageslist.Add(0);

            //Initializing the scroll bar
            HscB_AnalogV.Minimum = -1000;
            HscB_AnalogV.Maximum = 1000 + HscB_AnalogV.LargeChange - 1; //bug when using scroll bar
            HscB_AnalogV.LargeChange = 10;
            HscB_AnalogV.SmallChange = 1;
            HscB_AnalogV.Value = 0;

            //Allowing 0V to be the default
            AnalogV = HscB_AnalogV.Value / 100.00;
            txtB_AOVoltage.Text = AnalogV.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            writer = new AnalogMultiChannelWriter(analogOutTask.Stream);

            try
            {

                ao_Channels = DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External);
                //voltageslist = new List<double>();
                Cbx_AOports.DropDownStyle = ComboBoxStyle.DropDownList; //Non-editable combobox
                Cbx_AOports.Items.AddRange(ao_Channels); //Adds channels to combobox
                lstB_DevVoltages.Items.Clear(); //Want to clear the list box before adding anything

                for (int i = 0; i < ao_Channels.Length; i++)
                {
                    lstB_DevVoltages.Items.Add(string.Format("{0}  {1} V", ao_Channels[i], AnalogV)); //ATTEMPTING to add DEV/Channel and Voltage to listbox
                }

                if (analogOutTask != null)
                {
                    for (int i = 0; i < Cbx_AOports.Items.Count; i++) // Loop through ports
                    {
                        string deviceChannels = Cbx_AOports.Items[i].ToString();
                        analogOutTask.AOChannels.CreateVoltageChannel(deviceChannels, "", -10, 10, AOVoltageUnits.Volts);
                        //create a V channel for each port
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("There was an issue getting the channels in the daq", ex.Message); }
            try
            {
                if (Cbx_AOports.Items.Count > 0)
                {
                    Cbx_AOports.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("DAQ is not turned on"); //Makes sure DAQ is on
                    this.Close(); //Closes the program
                }
            }
            catch (Exception ex)
            { MessageBox.Show("There was an error in selecting the index", ex.Message); }

        }

        private void HscB_AnalogV_Scroll(object sender, ScrollEventArgs e)
        {      
            double AnalogV = HscB_AnalogV.Value / 100.00;
            txtB_AOVoltage.Text = AnalogV.ToString();
            int selectedIndex = Cbx_AOports.SelectedIndex;


            if (selectedIndex == 0)
            {
                voltageslist[selectedIndex] = AnalogV;
                lstB_DevVoltages.Items[0] = (string.Format("{0}  {1} V", ao_Channels[selectedIndex], AnalogV));
            }
            else
            {
                voltageslist[selectedIndex] = AnalogV;
                lstB_DevVoltages.Items.RemoveAt(selectedIndex);
                lstB_DevVoltages.Items.Add(string.Format("{0}  {1} V", ao_Channels[selectedIndex], AnalogV));
            }

                writer.WriteSingleSample(true, voltageslist.ToArray());         
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (analogOutTask != null)
            {
                double[] zero_arr = { 0, 0 };
                writer.WriteSingleSample(true, zero_arr);
                analogOutTask.Dispose(); 
            //Do not put application Exit !!!! Will go into the form closing
            }
        }

        private void Cbx_AOports_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Cbx_AOports.SelectedIndex;
            txtB_AOVoltage.Text = voltageslist[selectedIndex].ToString();
            HscB_AnalogV.Value = (int)voltageslist[selectedIndex];
        }
    }
}
