use university
create table Student(
id int not null,
name varchar(49),
GPA decimal,
Advisor varchar(50),
department varchar(50),
semester varchar(50),
);

alter table Student
alter column GPA decimal(2)

insert into Student(id,name,GPA,Advisor,department,semester)
values(001,'Hussain',3.4,'Mr.Ahmad','BBA',3),
(002,'Hasan', 3.98,'Mr.Riaz','IT',6),
(003,'Abbass',3.56,'Mr.Haider','CS',7),
(004,'Zia Hakimi',2.2,'Mr.Riaz','BBA',8),
(005,'Zainab', 3.0, 'Mr.Haider', 'IT',1),
(006,'Zahra', 3.98, 'Mr.Riaz','SE',4)

select * from Student


update Student
set GPA=GPA+0.2;
select * from Student


update Student
set Advisor='Mr.Ahmad'

select * from Student

update Student
set department='business administration'
where department='BBA';

select * from Student

update Student
set GPA= GPA-0.2
where GPA>3.9;

select * from Student


select  name, GPA from Student

select Department, count(*) as total_student from Student
group by department

select semester,AVG(GPA) as average_gpa from Student
group by semester

select Department, Min(GPA) as min_gpa,MAX(GPA) as max_gpa from Student
group by department

select Advisor, AVG(GPA) as average_GPA from Student
group by Advisor

select Department,AVG(GPA) as average_gpa from Student
group by department
having AVG(GPA) =4;


select advisor,count(name) as students from Student
group by Advisor
having count(name)>3

select Department,sum(GPA) as total_GPA from student
group by department
having sum(GPA)>2;

select semester , AVG(GPA) as average_GPA from Student
group by semester 
having AVG(GPA) <4;

select GPA + Semester as total from Student;

select * from Student;

select name , Department from Student
where GPA + semester >8;


select * from Student

select count( Department) as totalDepartment,department
from Student
group by department

