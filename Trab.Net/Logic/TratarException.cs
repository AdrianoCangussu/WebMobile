using System;

namespace Trab.Net.Logic
{
    public class TratarException
    {
        public static string ErrorMessage(Exception ex)
        {
            var msg =
                string.IsNullOrWhiteSpace(ex.Message) ?
                ex.InnerException.Message :
                ex.Message;

            return msg;
        }
    }
}
