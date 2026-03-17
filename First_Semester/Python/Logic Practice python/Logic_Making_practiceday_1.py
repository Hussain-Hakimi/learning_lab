# 1_Find the sum of two numbers
def add(a,b):
    return a+b
result=add(45,33)
print(result)


# 2_Determine if a number is even or odd
def Odd_numbers(a):
    if a%2==0:
        return "even"
    else:
        return "odd"
print(Odd_numbers(5))

# 3_Find the largest of three numbers

def Largest_numbers(a, b, c):
    if a > b and a > c:

        return "largest_number is: " + str(a)
    if b > c and b > a:
        return "largest_number is: " + str(b)
    else:
        return "largest_number is: " + str(c)

# second way to solve this with build_in

def largest_numbers(a, b, c):
    return max(a, b, c)

print(Largest_numbers(5, 4, 3))

# 4_Reverse a string
def reverse_sting(S):
    return S[::-1]
print(reverse_sting("Hussain"))








