using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_tests
{
  public static class ClasseChaine
  {
    /// <summary>
    /// Retourne les initiales des prénoms et noms passés en paramètre.
    /// </summary>
    /// <param name="lastname">Nom</param>
    /// <param name="firstname">Prénom</param>
    /// <example>["JEANNE", "Alexis"] = JA</example>
    /// <example>["Nom-Composé", "Prénom"] = NCP</example>
    /// <example>["Nom", "Prénom-Composé"] = NPC</example>
    /// <example>["Nom Composé", "Prénom Composé"] = NCPC</example>
    /// <example>["Nom Composé", ""] = ""</example>
    /// <example>["", "Prénom Composé"] = ""</example>
    /// <returns></returns>
    public static string RetourneInitiales(string lastname, string firstname)
    {
      string initiale = "";
      if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
      {
        return "";
      }

      string[] listPrenom = firstname.Split(' ', '-');
      string[] listNom = lastname.Split(' ', '-');

      foreach (var item in listNom)
      {
        initiale += item.Substring(0, 1);
      }

      foreach (var item in listPrenom)
      {
        initiale += item.Substring(0, 1);
      }

      return initiale;
    }
  }
}
