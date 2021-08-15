using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.DB;
using WalletBuddy.Model;

namespace WalletBuddy.Executor
{
  class TokenServices
  {
    TokenDataAccess tokenDataAccess;

    public TokenServices()
    {
      this.tokenDataAccess = new TokenDataAccess();
    }

    public int AddToken(SupportToken token)
    {
      return tokenDataAccess.AddToken(token);
    }

    public List<SupportToken> GetAllTokenList()
    {
      return tokenDataAccess.GetAllTokenList();
    }

    public int ChangeStatus(SupportToken token)
    {
      return tokenDataAccess.ChangeStatus(token);
    }

  }
}
