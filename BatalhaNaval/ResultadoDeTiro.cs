﻿using System;

namespace BatalhaNaval
{
    /// <summary>
    /// Enumerador para resultados de tiro
    /// </summary>
    [Flags]
    public enum ResultadoDeTiro : uint
    {
        Errou   = 0x000000,
        Acertou = 0x010000,
        Afundou = 0x020000 | Acertou,
        Ganhou  = 0x040000 | Acertou | Afundou,
        
        Invalido = 0xffffff
    }    

    /// <summary>
    /// Classe de extensão para o enumerador de resultados de tiro
    /// </summary>
    public static class ResultadoDeTiro_Ex
    {
        /// <summary>
        /// Obtém o tipo de navio acertado por um tiro
        /// </summary>
        public static TipoDeNavio TipoDeNavio(this ResultadoDeTiro r)
        {
            return (TipoDeNavio)((int)r & 0xffff);
        }
    }
}
