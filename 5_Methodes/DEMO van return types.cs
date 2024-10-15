private void AddOperation()
        {
            // Auto format : eerst code selecteren, dan Ctrl + K + F
            int number = int.Parse(totalSumTextBox.Text);
            number += 1;
            totalSumTextBox.Text = number.ToString();


            DoStuff();
            string question = AskQuestion();
            int som = Plus(10, 10);
        }

        // DEMO return type

        private void DoStuff()
        {
            MessageBox.Show("Hey");
        }

        private string AskQuestion()
        {
            return "Welkom?";
        }

        private int Plus(int x, int y)
        {
            int som = x + y;
            return som;
        }