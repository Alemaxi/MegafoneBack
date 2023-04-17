using Domain.core.DTO;
using Domain.core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlRepository.Repository
{
    public class MegaFoneRepository: IMegaFoneRepository
    {
        MysqlContext _context;

        public MegaFoneRepository(MysqlContext context)
        {
            _context = context;
        }

        public async Task<MegaFoneDTO?> ObterMegaFonePorId(int id)
        {
            var resultado = _context.MegaFones.AsNoTracking().Where(x => x.Id== id)
                .Select(x => new MegaFoneDTO { Id = x.Id, Nome = x.Nome, idMensageiro = x.MensageiroId }).FirstOrDefault();

            return resultado;
        }

        public Task<IEnumerable<MegaFoneDTO>> FiltrarMegaFonesPorNome(string nome)
        {
            var resultados = _context.MegaFones.AsNoTracking().Where(x => x.Nome.ToLower().Contains(nome.ToLower()))
                .Select(x => new MegaFoneDTO { Id = x.Id, idMensageiro = x.MensageiroId, Nome = x.Nome }).AsEnumerable();

            return Task.FromResult(resultados);
        }

        public Task<IEnumerable<MegaFoneDTO>> FiltrarMegaFonesPorMensageiro(int idMensageiro)
        {
            var resultados = _context.MegaFones.AsNoTracking().Where(x => x.MensageiroId == idMensageiro)
                .Select(x => new MegaFoneDTO { Id = x.Id, idMensageiro = x.MensageiroId, Nome = x.Nome }).AsEnumerable();

            return Task.FromResult(resultados); 
        }

        public Task<IEnumerable<MegaFoneDTO>> ObterMegaFonesPorReceptorId(int idReceptor)
        {
            var resultados = _context.MegaFones.AsNoTracking().Where(x => x.ReceptoresXMegaFones.Where(y => y.ReceptorId == idReceptor).Count()>0)
                .Include(x => x.ReceptoresXMegaFones)
                .Select(x => new MegaFoneDTO { Id = x.Id, idMensageiro = x.MensageiroId, Nome = x.Nome }).AsEnumerable();

            var item = _context.MegaFones.SelectMany(x => x.ReceptoresXMegaFones).ToList();

            return Task.FromResult(resultados); //retorna uma tarefa que contém o resultado da consulta acima, que é um IEnumerable de MegaFoneDTO, que é o que o método espera receber como
        }

        public Task<MegaFoneDTO> CriarMegaFone(MegaFoneDTO megaFone)
        {
            throw new NotImplementedException();
        }

        public Task<MegaFoneDTO> AtualizarMegaFone(MegaFoneDTO megaFone)
        {
            throw new NotImplementedException();
        }

        public Task<MegaFoneDTO> RemoverMegaFone(MegaFoneDTO megaFone)
        {
            throw new NotImplementedException();
        }
    }
}
