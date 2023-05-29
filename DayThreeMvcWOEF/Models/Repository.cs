namespace DayThreeMvcWOEF.Models
{
    public class Repository
    {
        private static List<Student> _repository=new();
        public static IEnumerable<Student> Students => _repository;
        public static bool AddStudent(Student student)
        {
            int prevId = _repository.Count;
            student.Id = prevId + 1;
            _repository.Add(student);
            return _repository.Count>prevId;
        }
        public static bool EditStudent(Student student)
        {
            int prevId = _repository.Count;
            student.Id = prevId + 1;
            _repository.Add(student);
            return _repository.Count > prevId;
        }
        public static bool DeleteStudent(int Id) { 
            int prevCount = _repository.Count;
            _repository.Remove(_repository.First(x => x.Id == Id));
           return _repository.Count < prevCount;
        }
    }
}
