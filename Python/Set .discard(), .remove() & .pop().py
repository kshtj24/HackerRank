n = int(input())
s = set(map(int, input().split()))

m = int(input())
for _ in range(0,m):
    command = input().split(' ')
    if len(command) == 2:
        eval('s.'+ command[0] + '('+command[1]+')')
    else:
        s.pop()
print(sum(s))