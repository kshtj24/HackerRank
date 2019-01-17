A = set(map(int,input().split(' ')))
n = int(input())
result = True

for _ in range(0,n):
    B = set(map(int,input().split(' ')))
    result = result and (True if (len(A.difference(B)) > 0 and A.issuperset(B)) else False)

print(result)

