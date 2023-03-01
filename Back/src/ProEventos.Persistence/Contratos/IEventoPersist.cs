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
       Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePlestrantes);

       Task<Evento[]> GetAllEventoAsync(bool includePlestrantes);

       Task<Evento> GetAllEventoByIdAsync(int eventoId, bool includePlestrantes);
    }
}