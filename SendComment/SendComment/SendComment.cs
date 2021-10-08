using System;
using TwicasAPI.v2.api;

namespace SendComment
{
    class SendComment
    {
        static void Main(string[] args)
        {
            try
            {
                var comment = new CommentAPI(GetConfigPath());
                if (args.Length > 0)
                {
                    if (int.TryParse(args[0], out int value))
                    {
                        comment.MaxIndex = value;
                    }
                }
                comment.PostComment();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 設定ファイルのパスを取得
        /// </summary>
        /// <returns>ファイルパス</returns>
        static private string GetConfigPath()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            return $"{path}config.json";
        }
    }
}
