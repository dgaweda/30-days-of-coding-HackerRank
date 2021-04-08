class Student : Person
{
    private int[] testScores;

    public Student(string firstName, string lastName, int id, int[] scores) 
        :base(firstName, lastName, id)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.testScores = scores;
    }

    public char Calculate()
    {
        var sum = 0;

        for (var i = 0; i < testScores.Length; i++)
        {
            sum += testScores[i];
        }
        var avg = sum / testScores.Length;

        if (avg >= 90 && avg <= 100)
        {
            return 'O';
        }
        else if (avg >= 80)
        {
            return 'E';
        }
        else if (avg >= 70)
        {
            return 'A';
        }
        else if (avg >= 55)
        {
            return 'P';
        }
        else if (avg >= 40)
        {
            return 'D';
        }
        else
            return 'T';
    }
}