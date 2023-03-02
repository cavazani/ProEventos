using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model);
        Task<Evento> UpdateEvento(int eventoId, Evento model);
        Task<bool> DeleteEvento(int eventoId);

        Task<Evento[]> GetAllEventosAsync(bool includePlestrantes = false);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePlestrantes = false);
        Task<Evento> GetAllEventoByIdAsync(int eventoId, bool includePlestrantes = false);
    }
}