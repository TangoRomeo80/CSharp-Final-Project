using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.Model;
using System.Data.SqlClient;

namespace WalletBuddy.DB
{
  class TokenDataAccess : DataAccess
  {
    public int AddToken(SupportToken token)
    {
      string sql = "INSERT INTO TOKEN_TBL(SENDER_NAME,SENDER_EMAIL,DESCRIPTION,STATUS) VALUES('" + token.SenderName + "','" + token.SenderEmail + "','" + token.Description + "','" + token.Status + "')";
      return this.ExecuteQuery(sql);
    }

    public List<SupportToken> GetAllTokenList()
    {
      string query = "SELECT * FROM TOKEN_TBL";
      SqlDataReader reader = GetData(query);
      List<SupportToken> tokenList = new List<SupportToken>();
      while (reader.Read())
      {
        SupportToken token = new SupportToken()
        {
          TokenId = Convert.ToInt32(reader["TOKEN_ID"]),
          SenderName = reader["SENDER_NAME"].ToString(),
          SenderEmail = reader["SENDER_EMAIL"].ToString(),
          Description = reader["DESCRIPTION"].ToString(),
          Status = reader["STATUS"].ToString()
        };
        tokenList.Add(token);
      }
      return tokenList;
    }

    public int ChangeStatus(SupportToken token)
    {
      string query = "UPDATE TOKEN_TBL SET STATUS = '" + "Complete" + "' WHERE TOKEN_ID = '" + token.TokenId + "'";
      return this.ExecuteQuery(query);
    }

  }
}
