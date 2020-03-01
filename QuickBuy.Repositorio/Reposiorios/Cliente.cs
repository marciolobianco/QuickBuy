using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Reposiorios
{
    public class Cliente
    {
        public Cliente()
        {
            UsuarioRepositorio usuarioRepoitorio = new UsuarioRepositorio();
            Produto produto = new Produto();
            Usuario usuario = new Usuario();
            usuarioRepoitorio.Adicionar(usuario);
        }

    }
}
