// Что следует добавить в сигнатуру метода, чтобы код скомпилировался?

int Method1<T>(T t1, T t2) 
{
	if (t1 == null) throw new ArgumentNullException("t");   
    if (t1 == null) t2 = new T();
    return t1.CompareTo(t2);
}