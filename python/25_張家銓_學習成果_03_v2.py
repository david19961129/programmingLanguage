
a = int(input("請輸入循環次數:"))             
for x in range(a):
  b = input("請輸入正整數:")

  s = b.strip("b[]'")
  # 用 , 分割每部分
  parts = s.split(',')

  # 计算每部分的数字和
  sums = []
  for part in parts:

      numbers = list(map(int, part))

      part_sum = sum(numbers)
      sums.append(part_sum)

  # 输出每部分的和
  print(b,"每個位數加總結果:", sums)
