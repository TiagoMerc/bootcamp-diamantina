using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers{
    public class TarefasController : Controller{

        public List<TarefaViewModel> listaDeTarefas{get;set;}
        public TarefasController()
        {
             listaDeTarefas = new List<TarefaViewModel>()
            {
                new TarefaViewModel() { Id = 1, Titulo = "Arrumando a cama", Descricao = " Dobrar a coberta e colocar em cima do travesseiro"},
                new TarefaViewModel() { Id = 2, Titulo = "Tomar Cafe", Descricao = "Pegar a garrafa e o queijo"},
                new TarefaViewModel() { Id = 3, Titulo = "Estudar C#", Descricao = "Ler introdução e visão geral"}
                
            };

            
        }

        public IActionResult Create(){
            return View();
        }

        public IActionResult Index()
        {
            return View(listaDeTarefas);
        
        }

        public IActionResult Details(int id){
            var tarefa = listaDeTarefas.Find(tarefa => tarefa.Id == id);
            return View(tarefa);
        }
    }
}
