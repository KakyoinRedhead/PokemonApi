using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonApi
{
    public partial class Pokemon : UserControl
    {
        protected Pokemon()
        {
            InitializeComponent();
        }
        public Pokemon(PokemonResponseJSON pokemonResponse) : this()
        {
            label1.Text = pokemonResponse.name;
            label2.Text = pokemonResponse.weight/10 + "kg";
            pictureBox1.Load(pokemonResponse.sprites.front_default);
            label3.Text = $"Výška: {pokemonResponse.height / 19} m \n" +
                $"XP za poražení: {pokemonResponse.base_experience}";
        }

    }
}
