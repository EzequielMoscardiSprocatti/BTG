﻿using System.Security.Claims;

namespace BTG.Dominio.Contratos;
public interface IUsuario
{
    string Name { get; }

    Guid GetUserId();

    string GetUserEmail();

    bool IsAuthenticated();

    bool IsInRole(string role);

    IEnumerable<Claim> GetClaimsIdentity();
}
