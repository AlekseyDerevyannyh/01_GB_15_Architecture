using ClinicServiceNamespace;
using System.CodeDom;

namespace ClinicDesktop
{
    public partial class ClinicMainForm : Form
    {
        private const string CLINIC_SERVICE_ADDRESS = "http://localhost:5076/";

        public ClinicMainForm()
        {
            InitializeComponent();
        }

        private void btnUpdateClients_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient(CLINIC_SERVICE_ADDRESS, new HttpClient());
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;

            listViewClients.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Document
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = String.Format("{0}.{1}.{2}", client.Birthday.Day.ToString(), client.Birthday.Month.ToString(), client.Birthday.Year.ToString())
                });
                listViewClients.Items.Add(item);
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient(CLINIC_SERVICE_ADDRESS, new HttpClient());
            //Client client = new Client();
            clinicClient.ClientCreateAsync(new CreateClientRequest
            {
                Document = textBoxDocument.Text,
                SurName = textBoxSurName.Text,
                FirstName = textBoxFirstName.Text,
                Patronymic = textBoxPatronymic.Text,
                Birthday = dateTimePickerBirthday.Value.Date
            });
            MessageBox.Show("Client added");

            textBoxDocument.Text = "";
            textBoxSurName.Text = "";
            textBoxFirstName.Text = "";
            textBoxPatronymic.Text = "";
            dateTimePickerBirthday.Value = DateTime.Now;
        }

        private void btnUpdatePets_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient(CLINIC_SERVICE_ADDRESS, new HttpClient());
            ICollection<Pet> pets = clinicClient.PetGetAllAsync().Result;

            listViewPets.Items.Clear();
            foreach (Pet pet in pets)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pet.PetId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.ClientId.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.Name
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = String.Format("{0}.{1}.{2}", pet.Birthday.Day.ToString(), pet.Birthday.Month.ToString(), pet.Birthday.Year.ToString())
                });
                listViewPets.Items.Add(item);
            }
        }
    }
}