print("----------------------------------------------question 1 --------------------------------")
# rpint numbers form 1 to ten use for loop

for i in range (1,11):
    print(i)

print("----------------------------------------------question 2 --------------------------------")

# print numbers from 1 to tem use while loop
j = 1 
while j<=10:
    print(j)
    j += 1

print("-------------------- -------------------------------questoin3---------------------------")
# print first 10 even numbers using for loop
for k in range (2,21,2):
    print(k)


print("--------------------------------------------------question 4 ------------------------")
 # print first 10 odd numbers using while loop 
n=1
while n<=19:
     print(n)
     n +=2

print("--------------------------------------------------question 5 ------------------------")
# print multiplication table of 5 and 7 using for loop
print("multiplication table of 5")
for m in range (1,11):
    print("5 x",m,"=",5*m)

print("multiplication table of 7")
for p in range (1,11):
    print("7 x",p,"=",7*p)

print("--------------------------------------------------question 6 -------------------------")
# print sum of numbers from 1 to 10 using whileloop
q = 1
sum=0
while q<=10:
    sum += q
    q +=1
    print("sum of numbers from 1 to 10 si ",sum)


print("-------------------------------------------------question 7 --------------------------")
# print fnumber from 1 to 20 skip number 13 using for loop to continue statement
for r in range (1,21):
    if r == 13:
        continue
    print(r)

print("-------------------------------------------------question 8 --------------------------")
# print numbers from 1 to 10 but stop if the number is 7 using while loop 
s= 1
while s<= 10:
    if s == 7:
        break
    print(s)
    s +=1

print("-------------------------------------------------question 9 --------------------------")
# print square of numbers from 1 to 5 using for loop
for t in range (1,6):
    print("square of",t,"is",t*t)

print("-------------------------------------------------questoin 10 --------------------------")

