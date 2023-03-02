using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
       //EVENTOS
       Task<Evento[]> GetAllEventosAsync(bool includePlestrantes = false);
       Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePlestrantes = false);

       Task<Evento> GetEventoByIdAsync(int eventoId, bool includePlestrantes = false);
    }
}