class Subject{
    string Name{get; set;}
}

class Student{
    public string Name { get; set;}
    public string facNum{get; set;}
    Dictionary<Subject, int> subjects;

    public Add(Subject subject, int grade){
        if(subjects.ContainsKey(subject))
            subjects[subject] = grade;
        else
            subjects.Add(subject, grade);
    }

    public SubjectCount{
        get =>
            subjects.Count();
    }

    public List<Subject> GetSubjects(){
        List<Subject> subjectsList = new();

        foreach(Subject subject in subjects.Keys)
            subjectsList.Add(subject);

        return subjectsList;
    }

    public int GetGradeBySubject(Subject subject){
        if(subjects.ContainsKey(subject))
            throw new Exception();

        return subjects[subject];
    }

    public double GetAverageGrade(){
        int sum = subjects.Average(s => s.Value);
        return (double)sum/SubjectCount;
    }

    public void PrintInfo(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Faculty num: {facNum}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

    }
}
