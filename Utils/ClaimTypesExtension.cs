using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RpgApi.Utils
{
    public static class ClaimTypesExtension
    {
        public static int ObterUsuarioId(this ClaimsPrincipal user)
        {
            var id =
                user.Claims
                    .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;

            return int.Parse(id);
        }
    }

    /* para modificação específica e pesquisa de dados com o token, alterar
    o "ClaimTypes.NameIdentifier" pelo número do token entre aspas duplas, ex: "563369313416343545". */
}