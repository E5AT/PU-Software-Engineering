class Subject
{
    public string Name{get; set;}

    public Subject(string name)
    {
        Name = name;
    }
}

class Student
{
    public string Name{get;init;}
    public string FacNum{get;init;}

    Dictionary<Subject, int> subjects;

    public Student(string name, string facNum)
    {
        Name = name;
        FacNum = facNum;
        subjects = new();
    }

    public void Add(Subject subject)
    {
        if(subject == null)
            throw new ArgumentNullException();

        else if(subjects.ContainsKey(subject))
            throw new ArgumentException("Subject already exists for this student.");
        
        else
            subjects.Add(subject, 0);
    }

    public void Add(Subject subject, int grade)
    {
        if(subject == null)
            throw new ArgumentNullException();

        else if(subjects.ContainsKey(subject))
            subjects[subject] = grade;

        else if(grade is >= 2 and <=6)
            subjects.Add(subject, grade);

        else
            throw new ArgumentException("Grade must be between 2 and 6.");
    }

    public int SubjectCount
    {
        get
        {
            return subjects.Count;
        }
    }

    public List<Subject> GetSubjects()
    {
        return subjects.Keys.ToList();
    }

    public int GetGrade(Subject subject)
    {
        if(subject == null)
            throw new ArgumentNullException();

        else if(!subjects.ContainsKey(subject))
            throw new ArgumentException("Subject not found for this student.");

        else
            return subjects[subject];
    }

    public double AverageGrade
    {
        get
        {
            int sum = 0, count = 0;
            
            foreach(int grade in subjects.Values)
            {
                if(grade!=0)
                    sum += grade;
                    count++;
            }

            return count > 0 ? (double)sum/count : 0;
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student: {Name}, Faculty Number: {FacNum}");
        Console.WriteLine("Subjects and grades:");
        foreach(Subject subject in subjects.Keys)
        {
            Console.WriteLine($"- {subject.Name}: {(GetGrade(subject) != 0 ? GetGrade(subject) : "Not graded yet")}");
        }
    }
}

class Specialty
{
    public string Name{get; init;}
    int CourseYear
    {
        get;
        set
        {
            if(value is >= 1 and <=4 )
                field = value;
            else
                throw new ArgumentException("Course year must be between 1 and 4.");
        }
    }

    List<Subject> CommonSubjects, Electives;
    List<Student> Students;

    public Specialty(string name, int courseYear)
    {
        Name = name;
        CourseYear = courseYear;
        CommonSubjects = new();
        Electives = new();
        Students = new();
    }

    public void AddStudent(string name, string fn, Subject[] eletives)
    {
        Students.Add(new Student(name, fn))
    }
}