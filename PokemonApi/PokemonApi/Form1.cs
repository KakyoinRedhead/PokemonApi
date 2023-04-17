using System.Text.Json;

namespace PokemonApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apiCesta = "https://pokeapi.co/api/v2/pokemon/" + textBox1.Text;
            HttpClient  client = new HttpClient();
            HttpResponseMessage responseMessage = client.GetAsync(apiCesta).Result;
            if(responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return;
            }
            string responseJSON = responseMessage.Content.ReadAsStringAsync().Result;
            PokemonResponseJSON pokemonResponse = JsonSerializer.Deserialize<PokemonResponseJSON>(responseJSON);
            Pokemon pokemon = new Pokemon(pokemonResponse);
            flowLayoutPanel1.Controls.Add(pokemon);
        }
    }
}