
﻿using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using AmigaoAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;


namespace AmigaoAPI.Infra.Data.Repositorios
{

    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ApplicationDbContext _db;

        public UsuarioRepositorio(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Usuario?> CreateAsync(Usuario usuario)
        {
            await _db.Usuarios.AddAsync(usuario);
            await _db.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario?> GetByIdAsync(int? id)
        {
            return await _db.Usuarios.FindAsync(id);
        }

        public async Task<Usuario?> GetByEmailAsync(string email)
        {
            return await _db.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task UpdateAsync(Usuario usuario)
        {
            _db.Usuarios.Update(usuario);
            await _db.SaveChangesAsync();
        }

        public async Task<bool> EmailDisponivelAsync(string email)
        {
            return !(await _db.Usuarios.AnyAsync(u => u.Email == email));
        }



        public async Task<bool> AutenticarAsync(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AtualizarSenhaAsync(int id, string novaSenha)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RecuperarSenhaAsync(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AtualizarPerfilAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AlterarTipoUsuarioAsync(int id, bool isChurrasqueiro)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> VerificarDisponibilidadeEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuario>> ListarUsuariosAsync()
        {
            throw new NotImplementedException();
        }

   
}
