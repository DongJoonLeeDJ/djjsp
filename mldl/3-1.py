import numpy as np
import matplotlib.pyplot as plt
from sklearn.model_selection import train_test_split
from sklearn.neighbors import KNeighborsRegressor
from aa.bb import doCC, fourReturn

perch_length = np.array(
    [8.4, 13.7, 15.0, 16.2, 17.4, 18.0, 18.7, 19.0, 19.6, 20.0,
     21.0, 21.0, 21.0, 21.3, 22.0, 22.0, 22.0, 22.0, 22.0, 22.5,
     22.5, 22.7, 23.0, 23.5, 24.0, 24.0, 24.6, 25.0, 25.6, 26.5,
     27.3, 27.5, 27.5, 27.5, 28.0, 28.7, 30.0, 32.8, 34.5, 35.0,
     36.5, 36.0, 37.0, 37.0, 39.0, 39.0, 39.0, 40.0, 40.0, 40.0,
     40.0, 42.0, 43.0, 43.0, 43.5, 44.0])
perch_weight = np.array(
    [5.9, 32.0, 40.0, 51.5, 70.0, 100.0, 78.0, 80.0, 85.0, 85.0,
     110.0, 115.0, 125.0, 130.0, 120.0, 120.0, 130.0, 135.0, 110.0,
     130.0, 150.0, 145.0, 150.0, 170.0, 225.0, 145.0, 188.0, 180.0,
     197.0, 218.0, 300.0, 260.0, 265.0, 250.0, 250.0, 300.0, 320.0,
     514.0, 556.0, 840.0, 685.0, 700.0, 700.0, 690.0, 900.0, 650.0,
     820.0, 850.0, 900.0, 1015.0, 820.0, 1100.0, 1000.0, 1100.0,
     1000.0, 1000.0])

plt.scatter(perch_length, perch_weight)
plt.xlabel('length')
plt.ylabel('weight')
# plt.show()

train_input, test_input, train_target, test_target \
    = train_test_split(perch_length, perch_weight, random_state=42)

print(train_input)
print(train_input.shape)
print(test_input.shape)
print(train_target.shape)
print(test_target.shape)

'''
    sklearn 라이브러리는... 
    훈련입력값들이(train_input) 2차원..[[10,300],[15,250],[30,500]]
    훈련타겟값들은(train_target) 1차원...(0,1) 
'''

test_array = np.array([1, 2, 3, 4])
print(test_array.shape)

test_array = test_array.reshape(2, 2)
print(test_array.shape)
print(test_array)

train_input = train_input.reshape(-1, 1)
test_input = test_input.reshape(-1, 1)

print(train_input)

print(train_input.shape, test_input.shape)

knr = KNeighborsRegressor()
knr.fit(train_input, train_target)

predict_length = 50
predict_weight = knr.predict([[predict_length]])
print('예측되는 무게', predict_weight)

plt.scatter(predict_length, predict_weight, marker='^', c='r')
plt.show()

# test_input 14개의 length 값이 들어가 있으니
# 예측되는 데이터도 14개가 나온다...
test_prediction = knr.predict(test_input)

print(test_input)
print(test_prediction)
print(test_target)

'''
    fit() 학습시키는 함수
    predict() 예측하는 함수
    score() 점수를 확인하는 함수
'''

# doCC()

# a, b, c, d = fourReturn()
# print(a)
# print(b)
# print(c)
# print(c[:3])
# print(d)
