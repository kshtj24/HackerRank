k = int(input())
arr = list(map(int, input().split()))
mSet = set(arr)
print(((sum(mSet)*k)-(sum(arr)))//(k-1))