#  1----Try making the program:Keep running until the user enters a valid number;;Also handle negative numbers
while True:
    try:
        number = float(input("Enter a positive number:  "))
        if number <0:
            print("Negative number is not allowed. Please try again.")
            continue
        break
    except ValueError:
        print("Invalid input. please enter a valid number.")
print(f" you entered a valid positive number:{number}")
