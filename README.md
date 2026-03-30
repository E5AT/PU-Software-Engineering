# PU Software Engineering - Course Materials

This repository contains lecture notes, exercises, coursework, and exam materials for the 1st year of the Software Engineering program at PU (Plovdiv University).

## Repository Structure

```
PU-Software-Engineering/
├── README.md
├── .gitignore
└── 1st course/
    ├── timetables/               # Weekly timetables (PDF format)
    │
    ├── 1st semester/
    │   ├── English language/     # English language course
    │   ├── LAAG/                 # Linear Algebra and Analytical Geometry
    │   │   ├── Courseworks/
    │   │   └── Exams/
    │   ├── OOP1/                 # Object-Oriented Programming 1
    │   │   ├── Competition/
    │   │   ├── Exercises/
    │   │   └── Lectures/
    │   ├── Programming/
    │   │   ├── Coursework/
    │   │   ├── Exercises/
    │   │   └── Lectures/
    │   └── WP1/                  # Web Programming 1
    │       ├── Coursework/
    │       └── Exercises/
    │
    └── 2st semester/
        ├── Algorithms and data structures/
        │   ├── Exam/             # Exam practice (ConsoleApp1-4)
        │   ├── Homeworks/        # Homework assignments
        │   └── Lectures/
        ├── Discrete structures/
        │   └── Lectures/
        └── Specialized English/
```

## Courses Included

### 1st Semester

- **English language** - General English language skills
- **LAAG** - Linear Algebra and Analytical Geometry
- **OOP1** - Object-Oriented Programming 1
- **Programming** - Introduction to Programming
- **WP1** - Web Programming 1

### 2nd Semester

- **Algorithms and Data Structures** - Fundamental algorithms and data structures
- **Discrete structures** - Discrete mathematics and structures
- **Specialized English** - Technical English for software engineering

## Content Types

Each course folder may contain:

- **Lectures** - Lecture notes and presentations
- **Exercises** - Exercise sheets and solutions
- **Coursework** - Assignment materials and submissions
- **Exams** - Past exam papers and solutions
- **Competition** - Competition materials (where applicable)

## Usage

This repository serves as a personal study resource. Students can:

1. Browse course materials by navigating to the appropriate semester and course folder
2. Review lecture notes and exercises for exam preparation
3. Reference past coursework and exam materials for guidance

## Contributing

This is a personal educational repository. Contributions from other students are welcome. To contribute:

1. Fork the repository
2. Create a new branch for your changes
3. Add your materials to the appropriate course folder
4. Submit a pull request

## License

This repository contains educational materials. Please respect academic integrity and copyright policies when using these materials.

## Projects

### CineLog

A movie logging web application built as coursework for the Programming course.

**Location:** `1st course/1st semester/Programming/Coursework/CineLog/`

**Tech Stack:**

- React 19
- Vite 7
- Tailwind CSS 4
- Supabase (backend database)
- React Router (routing)
- Lucide React (icons)
- ESLint

**To run the project:**

```bash
cd "1st course/1st semester/Programming/Coursework/CineLog"
npm install
npm run dev
```

**Available scripts:**

- `npm run dev` - Start development server
- `npm run build` - Build for production
- `npm run lint` - Run ESLint
- `npm run preview` - Preview production build

**Environment Variables:**
Create a `.env` file in the project root with your Supabase credentials:

```
VITE_SUPABASE_URL=your_supabase_url
VITE_SUPABASE_ANON_KEY=your_supabase_anon_key
```

### Algorithms and Data Structures Exam Practice

A C# console application for exam practice, implementing fundamental data structures and algorithms.

**Location:** `1st course/2st semester/Algorithms and data structures/Exam/`

**Tech Stack:**

- .NET 8.0
- C#

**Projects Included:**

- `ConsoleApp1` - First exam practice project
- `ConsoleApp2` - Second exam practice project
- `ConsoleApp3` - Third exam practice project
- `ConsoleApp4` - Fourth exam practice project

**Homework Assignments:**

- `Homework1` - First homework assignment
- `Homework2` - Second homework assignment

**To run a project:**

```bash
cd "1st course/2st semester/Algorithms and data structures/Exam/ConsoleApp1"
dotnet run
```

Or open the solution file in Visual Studio.
