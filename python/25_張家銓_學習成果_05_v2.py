a='25_張家銓_學習成果_05_文字檔txt_v1'
print('txt檔名:',a)
f=open(a, 'r', encoding='UTF-8')
s=f.read()
x=0

for c in s:
    if c != '\n':
     print(c,'萬國碼',ord(c))
     x+=ord(c)

print('萬國碼加總',x)
print('---------------')
a=input("請輸入txt檔名:")
print(a)
f=open(a, 'r', encoding='UTF-8')
for c in s:
    if c != '\n':
     print(c,'萬國碼',ord(c))
     x+=ord(c)

print('萬國碼加總',x)