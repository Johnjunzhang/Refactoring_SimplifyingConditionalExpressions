using System;

namespace SimplifyingConditionalExpressions.RemoveControlFlag
{
    public class ReplacedWithBreak
    {
        public string AlertedMessage { get; private set; }

        public void CheckSecurity(String[] people)
        {
            var found = false;
            foreach (var name in people)
            {
                if (!found)
                {
                    if (name.Equals("Don"))
                    {
                        SendAlert();
                        found = true;
                    }
                    if (name.Equals("John"))
                    {
                        SendAlert();
                        found = true;
                    }
                }
            }
        }

        private void SendAlert()
        {
            AlertedMessage = "Alert";
        }
    }
}