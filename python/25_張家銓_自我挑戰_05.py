def generate_matrix(limit):
    matrix = []
    current_number = 0

    while current_number <= limit:
        row = []
        for i in range(10):  # 每行填充 5 個數字
            if current_number > limit:
                break


            if current_number == 12:
                row.append(0)
            else:
                    row.append(current_number)
            current_number += 1
        matrix.append(row)

    return matrix


result_matrix = generate_matrix(99)


# 顯示結果
def show2d(d):
    for row in d:
        print(row)


show2d(result_matrix)