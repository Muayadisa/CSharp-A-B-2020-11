# Class task abstract

- All the properties are in propfull. add conditions.
- Each class should contain: constructor, toString().

### Write an abstract class: `Person`

- Properties:
  - name
  - age
  - ID
  - address

### Write class `Course`

- Properties:
  - name
  - grade
  - semester
  - teacher (type Teacher)

### Write class: `Student` that inherites from `Person`

- Properties:
  - Year
  - grades avg
  - Array of courses. (type: Course class)

### Write class: `Teacher` that inherites from `Person`

- Properties:
  - ID employee
  - Salary
  - Array of courses. (type: Course class)

### In main:

- array of 5 `Person` class. (with 5 new instances - 3 students and 2 teachers).
- If `Person` is a student - print the data for student.
- If `Person` is a teacher - print the data for teacher.
