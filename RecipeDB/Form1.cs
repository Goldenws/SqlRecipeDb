using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace RecipeDB
{
    public partial class CookBook : Form
    {
        string connectionString;
        SqlConnection connection;
        public CookBook()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["RecipeDB.Properties.Settings.RecipeDBConnectionString"].ConnectionString;
        }

       

        private void Recipe_Click(object sender, EventArgs e)
        {

        }

        private void CookBook_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
        }

        private void PopulateRecipes()
        {
            using(connection = new SqlConnection(connectionString))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                listRecipe.DisplayMember = "Name";
                listRecipe.ValueMember = "Id";
                listRecipe.DataSource = recipeTable;
            }
        }

        private void PopulateIngredients()
        {
            string query = "SELECT Recipe.Name, Ingredient.Name FROM Recipe JOIN RecipeIngredient ON Recipe.Id = RecipeIngredient.RecipeId JOIN Ingredient ON Ingredient.Id = RecipeIngredient.IngredientId";




            using (connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            using(SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                //get recipe id from the listRecipe listBox
                command.Parameters.AddWithValue("@RecipeId", listRecipe.SelectedValue);
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                listIngredient.DisplayMember = "Name";
                listIngredient.ValueMember = "Id";
                listIngredient.DataSource = ingredientTable;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngredients();
        }
    }
}
