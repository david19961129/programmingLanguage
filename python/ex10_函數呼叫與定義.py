x=10
print('全域',x)

def aaa():
    #區域變數只在函數內有效 生命短暫
    #函數內可用 global聲明全域

    x=-1
    print('函數內修改 全域x',x)

aaa()
x=30
print('全域x',x)