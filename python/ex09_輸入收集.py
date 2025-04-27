def 輸入正整數():
    次數=int(input("輸入次數:"))

    列表=[]
    for x in range(次數):
        print(x)
        正整數=input('輸入正整數:')
        列表.append(正整數)

    return 列表