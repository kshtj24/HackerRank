#Lists

if __name__ == '__main__':
    N = int(input())
    mList = []
    for row in range(N):
        command = input().split(' ')
        if command[0] == 'insert':
            mList.insert(int(command[1]),int(command[2]))
        elif command[0] == 'remove':
            mList.remove(int(command[1]))
        elif command[0] == 'append':
            mList.append(int(command[1]))
        elif command[0] == 'reverse':
            mList = mList[::-1]
        elif command[0] == 'pop':
            mList.pop()
        elif command[0] == 'sort':
            mList.sort()
        else:
            print(mList)

