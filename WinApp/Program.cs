using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace WinApp
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }

    public static class Actions
    {
        public static IEnumerable<string> GetGroups(string mnemo)
        {
            var liste = new List<string>();
            var ctx = new PrincipalContext(ContextType.Domain);
            UserPrincipal user = UserPrincipal.FindByIdentity(ctx, mnemo);
            if (user != null)
            {
                foreach (var group in user.GetGroups().OrderBy(o => o.Name))
                {
                    liste.Add(group.Name);
                }
                return liste;
            }
            else
            {
                throw new Exception("Utilisateur non trouvé : " + mnemo);
            }
        }

        public static string GetName(string mnemo)
        {
            var ctx = new PrincipalContext(ContextType.Domain);
            UserPrincipal user = UserPrincipal.FindByIdentity(ctx, mnemo);
            if (user != null)
            {
                return user.DisplayName;
            }
            else
            {
                throw new Exception("Utilisateur non trouvé");
            }
        }

        public static bool AddUserToGroup(string mnemo, string group)
        {
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain))
            {
                GroupPrincipal groupe = GroupPrincipal.FindByIdentity(pc, group);
                try
                {
                    groupe.Members.Add(pc, IdentityType.SamAccountName, mnemo);
                    groupe.Save();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
