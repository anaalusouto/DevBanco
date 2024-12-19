using System.Collections.Generic;
using System.Data.SqlClient;
using AutoMapper;
using Dapper;
using Microsoft.Data.SqlClient;
using WebAPICurrentAccount.Dto;
using WebAPICurrentAccount.Models;

namespace WebAPICurrentAccount.Services
{
    public class UserService : IUserInterface
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;


        public UserService(IConfiguration configuration, IMapper mapper) {
        
            _configuration = configuration;
            _mapper = mapper;

        }
        public async Task<ResponseModel<List<UserListarDto>>> SearchUser()

        {
            ResponseModel < List < UserListarDto >> response = new ResponseModel<List<UserListarDto>> ();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var usersDB = await connection.QueryAsync<User>("SELECT * FROM Users"); //Puxar as informações do BD e da tabela desejada

                if(usersDB.Count() == 0)
                {
                    response.Mensagem = "Nenhum usuário Localizado";
                    response.Situação = false;
                    return response;


                }

                var userMapped = _mapper.Map<List<UserListarDto>>(usersDB);

               response.Dados = userMapped;
               response.Mensagem = "Usuários Localizados com sucesso";
            }

            return response;
        }
    }
}
