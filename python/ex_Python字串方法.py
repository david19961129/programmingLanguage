txt = "welcome to the jungle" #字串轉成陣列
x = txt.split()# 可填入分隔判斷物與分割次數
print(x)
print("------------------\n")


txt = "welcome to the jungle"
x=txt.replace("jungle","Hell") #替換
print(x)
print("------------------\n")

fruits = ['apple', 'banana', 'cherry']
result = "$ ".join(fruits) #間格替換
print(result)
print("------------------\n")

txt = "  Hello  "
stripped_txt = txt.strip()  # 去除空白處
print(stripped_txt)
print("------------------\n")

txt = "Hello"
lower_txt = txt.lower()  # 轉小寫
print(lower_txt)
print("------------------\n")

txt = "Hello"
upper_txt = txt.upper()  #  轉大寫
print(upper_txt )
print("------------------\n")

txt = "Hello World"
position = txt.find("o")  # 條件第幾個出現
print(position )
print("------------------\n")

txt = "Hello World"
count = txt.count("o")  #  條件第幾次出現
print(count  )
print("------------------\n")

txt = "Hello World"
starts_with_hello = txt.startswith("Hello") #  條件開頭時，是否出現
print(starts_with_hello)
print("------------------\n")

txt = "Hello World"
ends_with_world = txt.endswith("World")  #  條件結尾，是否出現
print(ends_with_world)
print("------------------\n")