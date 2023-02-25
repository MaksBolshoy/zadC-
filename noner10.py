#Задача 10: На столе лежат n монеток. 
#Некоторые из них лежат вверх решкой, а некоторые – гербом.
# Определите минимальное число монеток, которые нужно перевернуть, 
#чтобы все монетки были повернуты вверх одной и той же стороной.
# Выведите минимальное количество монет, которые нужно перевернуть
"""
n = int(input())
k = 0
for i in range(n):
    b = int(input())
    if b == 1:  
       k += 1
       print (k)
    #if k <n/2:
#else n-k
#print (k)
#print(k if k<n/2 else n-k)
"""
"""
n = int(input())
count_zero = 0
count_one = 0
for i in range(n):
    x = int(input())
    if x == 0:
        count_zero += 1
    else:
        count_one += 1
if count_one > count_zero:
    print(count_zero)
else:
    print(count_one)
"""
"""
n = int(input())
count_zero = 0
count_one = 0
for i in range(n):
    x = int(input())
    if x == 0:
        count_zero += 1
    else:
        count_one += 1
if count_one > count_zero:
    print(count_zero)
else:
    print(count_one)

"""
"""
n = int(input())
count_zero = 0
count_one = 0
for i in range(n):
    x = int(input())
    if x == 0:
        count_zero += 1
    else:
        count_one += 1
if count_one > count_zero:
    print(count_zero)
else:
    print(count_one)

"""
import random
n = int(input('Введите колличество монет: '))
a = random.randint(1, n) 
print(a)
b =n-a
if (a<=b):
    print(a)
else:
    print(b)    