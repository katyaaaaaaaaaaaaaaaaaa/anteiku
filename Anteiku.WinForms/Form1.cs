using Anteiku.BLL.UseCases;
using Anteiku.DAL;
using Anteiku.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.WinForms
{
    public partial class Form1 : Form
    {
        private readonly DishService _dishService;

        public Form1()
        {
            InitializeComponent();
            #region CONTEXT

            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AnteikuDb;Trusted_Connection=True;";

            DbContextOptionsBuilder<AnteikuContext> optionsBuilder = new();

            optionsBuilder.UseSqlServer(connectionString);

            //optionsBuilder.UseInMemoryDatabase("AnteikuDb");

            AnteikuContext _db = new AnteikuContext(optionsBuilder.Options);

            #endregion

            #region REPOSITORIES
            DishRepository dishRepository = new DishRepository(_db);
            #endregion

            #region BLL_SERVICES

            _dishService = new DishService(dishRepository);

            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dishes = _dishService.GetDishesWithPagination(1, 10);

            listBox1.Items.Add(dishes.Select(x=>x.Title).FirstOrDefault());
        }
    }
}