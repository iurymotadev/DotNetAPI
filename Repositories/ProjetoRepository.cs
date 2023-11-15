using DotNetAPI.Contexts;
using DotNetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DotNetAPI.Repositories
{
public class ProjetoRepository
{
private readonly ExoContext _context;
public ProjetoRepository(ExoContext context)
{
_context = context;
}
public List<Projeto> Listar()
{
return _context.Projetos.ToList();
}
}
}