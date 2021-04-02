using DesafioApi.Model;
using DesafioApi.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Repository.Implementation
{

    public class UsuarioRepositoryImplementation : IUsuarioRepository
    {

        private MySQLContext _context;
        public UsuarioRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Usuario Create(Usuario usuario)
        {
            try
            {
                _context.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuario;
        }

        public Usuario Update(Usuario usuario)
        {
          
            if (!Exists(usuario.Id)) return new Escola();

            var result = _context.Escolas.SingleOrDefault(b => b.Id == usuario.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(usuario);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return result;
        }

        public bool Exists(long id)
        {
            return _context.Escolas.Any(b => b.Id.Equals(id));
        }

        public List<Usuario> FindAll()
        {
            return _context.Escolas.ToList();
        }

        public Usuario FindById(long id)
        {
            return _context.Escolas.SingleOrDefault(p => p.Id.Equals(id));
        }


        public void Delete(long id)
        {
            var result = _context.Escolas.SingleOrDefault(i => i.Id.Equals(id));
            try
            {
                if (result != null) _context.Escolas.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
