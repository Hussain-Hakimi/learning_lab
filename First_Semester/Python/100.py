# assign a value to three variables a, b, c in one line and then swap thier  values.
a, b, c, = 5, 15, 20
a, b, c, = c, b, a
print("done swapping,", a, b, c,)

# assign the same value to multiple variables and later change only one, print all to observe the results.
e = f = g = 6
f = 7
print(e, f, g)

# use anpacking to exchange the values of two variables without using a temporaty one.
x = 10
y= 25 
x, y = y, x
print(x,y)

# assign a string and an integer to two variables annd reassign them by swapping their types using type casting.
num = "100"
m = 200
num, m = int(num), str(m)
print(num, m)

# Assign two variables in one line and then reassign one by casting it into a float 
p,q = 7, 14
p = float(p)
print(p,",", q)

# Take an integer and cast cast it into a string,float, and boolean sequentially, print the outputs with comments explaining the results.
value= 42
st_value = str(value)
fl_value= float(st_value)
bool_value = bool(fl_value)



# 7,,,Write a program that demonstrates implicit and explicit type casting in a single expression.
int_number = 5
float_number = 5.5
str_number = "5"
result= (int_number + float_number ) + int(str_number)
print(result)
print(type (result))





# 8. Cast a float to an integer and analyze the data loss through outputs and comments.
value_float = 8.45
value_int = int(value_float)
print("original float value:", value_float) 
print("After casting to int:", value_int)
print("Data looss accurs as the decimal part is truncated whe casting from float to int.")
print(type(value_float), "->", type(value_int))
print(" data loss is , " , value_float - value_int)

 

# 9. Store a numeric string in a variable and convert it into both int and float, printing their types.
num_str = "123.45"
int_num = int(float (num_str))
float_num = float(num_str)
print(type(int_num), type(float_num))

#10 Add comments in code that explain each type conversion when performing arithmetic between int and string types after explicit casting.
int_var = 10 
str_var = "25"
sum_result = int_var + int(str_var) # explicitly casting str_var to int for addition
print("su of int and string after casting:", sum_result)

# 11 Concatenate an integer (through casting) with a string message in multiple ways and print results.
int_value = 50
str_massage = "The value is: "
# Method 1: Using str() for casting
concat1 = str(int_value) + str_massage
print(concat1)
# Method 2: Using f-string
concat2 = f"{str_massage}{int_value}"
print(concat2)
#Method 3: using format()
concats3 = "{}{}".format(str_massage, int_value)
print(concats3)
# 12. Show concatenation using both + and f-string, and check which syntax is more readable.
str1 = "Hello, "
str2 = "world!"
# Using +
concat1 = str1 + str2
print(concat1)
# using f-string
concat2 = f"{str1}{str2}"
print(concat2)

# 13. Concatenate three strings stored in different variables and display the result using f-string.
a = "python"
b = "is"
c = "fun"
result = f"{a} {b} {c}"
print(result)

# 14. Observe the behavior when concatenating immutable strings inside a loop and discuss memory implications via printed outputs.
base_str = "loop"
for i in range(3):
    base_str += f"_{i}"
    print(base_str)

# 15. Add two integer variables and store their sum in a variable with the same name as one operand; print the result.
num1 = 5
num2 = 10
num1 = num1 + num2
print(num1)
# 16. Write an arithmetic expression combining addition, subtraction, multiplication, and division; print the evaluated result.
result = (10 + 15 - 5) * 2/5
print(result)

# 17 use parentheses to change operation precedence in an arithmetic expression and compare outputs.
output1 = 10 + 5 * 2 # wothout parentheses
output2 = (10 + 5) * 2 # with parenthesses
print(f("without parentheses: {output1}, with parentheses: {output2}"))

# 18 Create an expression using modular division and floor division and display both results.
mod_result = 17 % 5
floor_result = 17 // 5
print(F"modular division: {mod_result}, floor division: {floor_result}")

# 19 Create a complex arithmetic expression containing both integers and floats and print the result type.
complex_result = (5 + 2.5) * (10 - 3) / 2
print(complex_result)
print(type(complex_result))

# 20 Perform exponentiation and integer division to simulate simple power and root operations.
power_result= 4 ** 3
root_result = 27 // 3
print(f"4 to the power of 3 is {power_result}, integer division of 27 by 3 is {root_result}")

# 21 Define a constant and use it inside an f-string to display a meaningful sentence.
PI = 3.14159 
print(f"The value of the constant PI is approximately {PI}.")

# 22 Demonstrate why a constant (written in uppercase) should not be reassigned.
GRAVITY = 9.81
print(f"initial GRAVITY value: {GRAVITY}")
# attempting to reasign (not recommended)
GRAVITY = 10.0
print(f"after reassignment GRAVITY value: {GRAVITY} (not recommended to change constants)")

# 23 Use an f-string to display results of arithmetic operations in a descriptive sentence.
a = 8 
b = 12 
sum_ab = a + b 
print (f"The sum of {a} and {b} is {sum_ab}.")

# 24 Combine variables and expressions inside an f-string and print multiple formatted lines.
length = 7
width =5
area = length * width
print(f"""The length is: {length}
      The width is: {width}
      Th area is: {area}""")
# 25 Display a user-like message using placeholders in an f-string with multiple variables
name= "Hussain Hakimi"
age = 21
print(f"Hello, my name is {name} and I am {age} years old.")

# 26 Compare two variables using all relational operators and print boolean outputs.
x = 5
y = 10
print(f"x==y: {x==y}")
print(f"x != y: {x!=y}")
print(f"x > y: {x>y}")
print(f"x<y : {x<y}")
print(f"x >= y: {x>=y}")
print(f"x <= y: {x<=y}")

# 27 Use a ternary (conditional) operator to choose between two messages.
age = 21
message = "You are an adult." if age >= 18 else "You are a minor."
print(message)

# 28 Check if a number is positive, negative, or zero using nested if-else.
num= 38
if num >= 0:
    if num == 0:
        print("The number is zero.")
    else:
        print("The number is positive.")
else:
    print("The number is negative.")

# 29 Use elif statements to categorize a percentage into grade bands (A, B, C, etc.).
percentage = 85
if percentage >= 90:
    grade = "A"
elif percentage >= 80:
    grade = "B"
elif percentage >= 70:
    grade = "C"
elif percentage >= 60:
    grade = "D"
else:
    print("F")
print(f"The grade is: {grade}")

# 30 Write a program with multiple if conditions to validate whether a number falls >within specific ranges.
number = 50
if 0 < number < 100:
    print("The number is between 0 and 100.")
else:
    print("The number is outside the range of 0 to 100.")
    
# 31 Use logical and, or, and not to verify multiple conditions on integer variables.
# 32 Create expressions with combined relational and logical operators to test edge cases.

