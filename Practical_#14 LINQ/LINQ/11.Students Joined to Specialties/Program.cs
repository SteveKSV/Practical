using _11.Students_Joined_to_Specialties;

List<StudentSpecialty> specialities = new List<StudentSpecialty>();
string input = Console.ReadLine().Trim();

while (input != "Students:")
{
    int indexOfLastSpace = input.LastIndexOf(' ');

    if (indexOfLastSpace > 0)
    {
        specialities.Add(new StudentSpecialty
        {
            SpecialtyName = input.Substring(0, indexOfLastSpace).Trim(),
            FacultyNumber = input.Substring(indexOfLastSpace + 1).Trim()
        });
    }

    input = Console.ReadLine().Trim();
}

List<Student> students = new List<Student>();
input = Console.ReadLine().Trim();

while (input != "END")
{
    int indexOfFirstSpace = input.IndexOf(' ');

    if (indexOfFirstSpace > 0)
    {
        students.Add(new Student
        {
            StudentName = input.Substring(indexOfFirstSpace + 1).Trim(),
            FacultyNumber = input.Substring(0, indexOfFirstSpace).Trim()
        });
    }

    input = Console.ReadLine().Trim();
}

var studentSpecialities = students.Join(specialities,
                    st => st.FacultyNumber,
                    sp => sp.FacultyNumber,
                    (st, sp) => new
                    {
                        Name = st.StudentName,
                        Faculty = st.FacultyNumber,
                        Speciality = sp.SpecialtyName
                    });

Console.WriteLine(
    string.Join(Environment.NewLine, studentSpecialities.OrderBy(st => st.Name)
                                     .Select(st => $"{st.Name} {st.Faculty} {st.Speciality}")));