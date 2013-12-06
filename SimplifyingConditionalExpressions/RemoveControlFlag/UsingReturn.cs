using System;

namespace SimplifyingConditionalExpressions.RemoveControlFlag
{
    public class UsingReturn
    {
        private string alertedMessage;

        public string CheckSecurity(String[] people)
        {
            var found = "";
            foreach (var name in people)
            {
                if (name.Equals("Don"))
                {
                    SendAlert();
                    found = "Don";
                }
                if (name.Equals("John"))
                {
                    SendAlert();
                    found = "John";
                }
            }
            return SomeLaterCode(found);
        }

        private string SomeLaterCode(string found)
        {
            return alertedMessage + found;
        }

        private void SendAlert()
        {
            alertedMessage = "Alert";
        }
    }
}