T = int(input())


for _ in range(0,T):
    a = int(input())
    A = set(map(int,input().split(' ')))
    b = int(input())
    B = set(map(int,input().split(' ')))
    print(True) if len(A.difference(B)) == 0 else print(False)