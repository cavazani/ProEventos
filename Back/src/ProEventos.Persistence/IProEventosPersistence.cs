using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        //GERAL
       void add<T>(T entity) where T: class; 
       void Update<T>(T entity) where T: class; 
       void Delete<T>(T entity) where T: class; 
       void DeleteRange<T>(T entity) where T: class; 
       Task<bool> SaveChangesAsync();

       //EVENTOS
       Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePlestrantes);

       Task<Evento[]> GetAllEventoAsync(bool includePlestrantes);

       Task<Evento> GetAllEventoByIdAsync(int EventoId, bool includePlestrantes);

       //PALESTRANTES
       Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos);

       Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);

       Task<Palestrante[]> GetAllPalestranteByIdAsync(int EventoId, bool includeEventos);
    }
}