﻿using Aplicacao.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Interfaces_Caso_De_Uso_e_Servicos
{
    public interface IListarChamadosAbertosUseCase
    {
        public List<ChamadoDTO> Executar();

    }
}
