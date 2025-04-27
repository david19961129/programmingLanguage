f=open('ex17_文字檔txt', 'a', encoding='UTF-8')
s=f.write('g,c,x')
x=0


for c in s:
    if c != '\n':
     print(c,'萬國碼',ord(c))
     x+=ord(c)
