namespace InstanceVariablePrac
{
    internal class Student
    {
        internal string name;
        internal int grade;

        public override string ToString()
        {
            return grade + "학년 " + name;
        }
    }
}