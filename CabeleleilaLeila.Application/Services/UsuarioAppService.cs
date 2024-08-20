using CabeleleilaLeila.Domain;
using CabeleleilaLeila.Domain.Core;
using CabeleleilaLeila.Domain.Enums;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CabeleleilaLeila.Application.Services
{
    public class UsuarioAppService
    {
        
        #region fields 
        private readonly CabeleleilaLeila.Data.Repositories.UsuarioRepository _usuarioRepository;
        #endregion


        #region constructor

        public UsuarioAppService()
        { 
            _usuarioRepository = new Data.Repositories.UsuarioRepository();
        }
        #endregion
        #region methods


        public DataTable LoadFromDatabase(IConfiguration config)
        {
            return _usuarioRepository.LoadFromDatabase(config);
        }
        public Usuario GetUsuario(IConfiguration config, string cdUsuario, string senha)
        {

            var usuario = _usuarioRepository.GetUsuarioLogin(config, cdUsuario, senha);
            return usuario;
        }

        public Usuario GetUsuarioPorCodigo(IConfiguration config, string cdUsuario) 
        {
            var usuario = _usuarioRepository.GetUsuarioPorCodigo(config, cdUsuario);
            return usuario;
        }

        public Usuario GetUsuarioById(IConfiguration config, Guid id)
        {
            var usuario = _usuarioRepository.GetUsuarioById(config, id);
            return usuario;
        }

        public Result NovoUsuario(IConfiguration config, string cdUsuario, string nome, UsuarioStatusEnum ativo, TipoUsuarioEnum tipo, string senha)
        {
            var usuario = new Usuario()
            {
                Id = Guid.NewGuid(),
                CdUsuario = cdUsuario,
                NomeUsuario = nome,
                Ativo = ativo,
                TipoUsuario = tipo,
                Senha = senha

            };

            var r = usuario.IsValid();
            if (!r.Success)
                return r;

            _usuarioRepository.InsertDatabase(config,usuario);

            return Result.Factory.True();
           
        }

        public Result UpdateUsuario(IConfiguration config, string cdUsuario, string nome, UsuarioStatusEnum ativo, TipoUsuarioEnum tipo, string senha, Guid id)
        {

            var usuario = _usuarioRepository.GetUsuarioById(config,id);
            if(usuario == null)
                return Result.Factory.False("Not Found");

            usuario.CdUsuario = cdUsuario;
            usuario.NomeUsuario = nome;
            usuario.Ativo = ativo;
            usuario.TipoUsuario = tipo;
            usuario.Senha = senha;



            var r = usuario.IsValid();
            if (!r.Success)
                return r;

            _usuarioRepository.UpdateDatabase(config, usuario);

            return Result.Factory.True();

        }

        public Result DeleteUsuario(IConfiguration config,  Guid id)
        {

            var usuario = _usuarioRepository.GetUsuarioById(config, id);
            if (usuario == null)
                return Result.Factory.False("Not Found");

       

            _usuarioRepository.DeleteDatabase(config, usuario);

            return Result.Factory.True();

        }

        #endregion
    }
}
