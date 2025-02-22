﻿using Senai_ProjetoAvanade_webAPI.Domains;
using Senai_ProjetoAvanade_webAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_ProjetoAvanade_webAPI.Interfaces
{
    public interface IReservaRepository
    {
        /// <summary>
        /// Método para criar uma nova reserva de uma vaga
        /// </summary>
        /// <param name="novareserva">Nova reserva a ser realizada</param>
        /// <param name="id">Id do usuario logado</param>>
        void Cadastrar(reservacadasViewModel novareserva, int id);

        /// <summary>
        /// Metodo responsavel pela atualização de horario de fechamento da reserva e preco
        /// </summary>
        /// <param name="id">Id da reserva para ser atualizada</param>
        /// <param name="ReservaAtualizada">Novas informacoes da reserva</param>
        void Atualizar(int id, reservaViewModel ReservaAtualizada);

        /// <summary>
        /// Metodo responsavel popr listar as reservas do usuario logado
        /// </summary>
        /// <param name="id">Id do usuario logado</param>
        /// <returns>Uma lista de reservas</returns>
        List<Reserva> Listar_Minhas(int id);

        /// <summary>
        /// Metodo responsavel pela atualizacao de Pontos em uma conta de usuarios após o pagamento
        /// </summary>
        /// <param name="id">Id do usuario atual logado</param>
        /// <returns>As informacoes do usuario logado</returns>
        Usuario AtualizarPontos(int id);

        /// <summary>
        /// Metodo responsavel por atualizar o status de pagamento de uma reserva
        /// </summary>
        /// <param name="id">Id da reserva a ser buscada</param>
        /// <param name="StatusAtualizada">Novo status de pagamento</param>
        void Atualizar_Status(int id, statuspagamentoViewModel StatusAtualizada);
    }
}
