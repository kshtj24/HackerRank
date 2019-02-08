n = int(input())
arr1 = list(map(int,input().split(' ')))
m = int(input())
arr2 = list(map(int,input().split(' ')))

mlist = [0]*10001

for i in range(0,n):
    mlist[arr1[i]] = mlist[arr1[i]] - 1

for j in range(0,m):
    mlist[arr2[j]] = mlist[arr2[j]] + 1

for index in range(0,len(mlist)):
    if(mlist[index] > 0):
        print(index,end=' ')