using Domain.core.DTO.Megafone;
using Domain.core.Entity;
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
            var resultados = _context.MegaFones.AsNoTracking().Where(x => x.Nome!.ToLower().Contains(nome.ToLower()))
                .Select(x => new MegaFoneDTO { Id = x.Id, idMensageiro = x.MensageiroId, Nome = x.Nome }).AsEnumerable();

            return Task.FromResult(resultados);
        }

        public Task<IEnumerable<MensageiroMegafoneDTO>> FiltrarMegaFonesPorMensageiro(int idMensageiro)
        {
            var resultados = _context.MegaFones.AsNoTracking().Where(x => x.MensageiroId == idMensageiro)
                .Select(x => new MensageiroMegafoneDTO { Id = x.Id, Nome = x.Nome, Descricao=x.Descricao}).AsEnumerable();

            return Task.FromResult(resultados); 
        }

        public Task<IEnumerable<ReceptorMegafoneDTO>> ObterMegaFonesPorReceptorId(int idReceptor)
        {
            var resultados = _context.MegaFones.AsNoTracking().Where(x => x.ReceptoresXMegaFones.Where(y => y.ReceptorId == idReceptor).Count()>0)
                .Include(x => x.ReceptoresXMegaFones)
                .Select(x => new ReceptorMegafoneDTO { Id = x.Id, Nome = x.Nome,Descricao = x.Descricao, QuantidadeMensagens= x.Mensagens.Count() }).AsEnumerable();

            var item = _context.MegaFones.SelectMany(x => x.ReceptoresXMegaFones).ToList();

            return Task.FromResult(resultados); //retorna uma tarefa que contém o resultado da consulta acima, que é um IEnumerable de MegaFoneDTO, que é o que o método espera receber como
        }

        public async Task<CriarMegafoneDTO> CriarMegaFone(CriarMegafoneDTO megaFone)
        {
            var result = _context.MegaFones.Add(new MegaFone 
            { 
                Nome=megaFone.Nome,
                Descricao= megaFone.Descricao, 
                MensageiroId=megaFone.idMensageiro 
            });

            _context.SaveChanges();

            return megaFone;
        }

        public Task<MegaFoneDTO> AtualizarMegaFone(MegaFoneDTO megaFone)
        {
            throw new NotImplementedException();
        }

        public Task<MegaFoneDTO> RemoverMegaFone(int id)
        {
            var result = _context.Remove<MegaFone>(new MegaFone { Id=id}).Entity;
            _context.SaveChanges();

            return Task.FromResult(new MegaFoneDTO { Id=result.Id});
        }

        public async Task CadastrarEmMegafone(CadastrarEmMegafoneDTO cadastrar)
        {
            _context.ReceptoresXMegaFones.Add(new ReceptorXMegaFone { ReceptorId = cadastrar.idReceptor, MegaFoneId = cadastrar.idMegafone });
            _context.SaveChanges();

            return;
        }
    }
}
