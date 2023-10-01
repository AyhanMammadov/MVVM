use Academy

select t.ID , t.Name , t.GroupID , g.Name as GroupName from Teachers t 
join Groups g on g.ID = t.GroupID



select g.Name , g.StudentCountt , t.Name as TeacherName from Groups g
join Teachers t on t.GroupID =g.TeacherID


select s.ID , s.Name , t.Name as TeacherName from Students s
join Teachers t on t.ID = s.TeacherID