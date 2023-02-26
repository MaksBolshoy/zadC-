#Задача 16: Требуется вычислить, сколько раз встречается некоторое число X
#  в массиве A[1..N]. Пользователь в первой строке вводит
#  натуральное число N – количество элементов в массиве.
#  В последующих  строках записаны N целых чисел Ai.
#  Последняя строка содержит число X
#*Пример:*
#5
   # 1 2 3 4 5
    #3
    #-> 1
"""
n = int(input())
a = map(int, input().split())
x = int(input())
print(sum(map(lambda z: int(z == x), a)))
"""
"""
input()
lst = map(int, (input().split()))
n = int(input())
inc = 0
for i in lst:
    if i == n:
        inc += 1
print(inc)
"""
N=abs(int(input('Введите колличество элементов списка А:')))
A_entered = input("Введите через пробел элементы списка: ").split()
A_num =list(map(int, A_entered))
if len(A_num) !=N:
    print('Введенные элементы не соответствуют зявленному колличеству ')
else:
    X = int(input('Введите число Х которое нужно найти в списке '))
    count = 0
    for i in range(N):
        if A_num[i]==X:
            count+=1
    print(f'Число {X} встречается в списке A {count} раз ')
