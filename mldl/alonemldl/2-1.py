import numpy as np
from sklearn.neighbors import KNeighborsClassifier
import matplotlib.pyplot as plt

fish_length = [25.4, 26.3, 26.5, 29.0, 29.0, 29.7, 29.7, 30.0, 30.0, 30.7, 31.0, 31.0,
                31.5, 32.0, 32.0, 32.0, 33.0, 33.0, 33.5, 33.5, 34.0, 34.0, 34.5, 35.0,
                35.0, 35.0, 35.0, 36.0, 36.0, 37.0, 38.5, 38.5, 39.5, 41.0, 41.0, 9.8,
                10.5, 10.6, 11.0, 11.2, 11.3, 11.8, 11.8, 12.0, 12.2, 12.4, 13.0, 14.3, 15.0]
fish_weight = [242.0, 290.0, 340.0, 363.0, 430.0, 450.0, 500.0, 390.0, 450.0, 500.0, 475.0, 500.0,
                500.0, 340.0, 600.0, 600.0, 700.0, 700.0, 610.0, 650.0, 575.0, 685.0, 620.0, 680.0,
                700.0, 725.0, 720.0, 714.0, 850.0, 1000.0, 920.0, 955.0, 925.0, 975.0, 950.0, 6.7,
                7.5, 7.0, 9.7, 9.8, 8.7, 10.0, 9.9, 9.8, 12.2, 13.4, 12.2, 19.7, 19.9]

fish_data = [[l, w] for l, w in zip(fish_length, fish_weight)]
fish_target = [1]*35 + [0]*14

# print(fish_data)
# print(fish_target)
# print(fish_data[5])
# print(fish_data[0:5])
# print(fish_data[:5])
# print(fish_data[44:])

train_input = fish_data[:35]
train_target = fish_target[:35]

test_input = fish_data[35:]
test_target = fish_target[35:]


knc = KNeighborsClassifier()
knc.fit(train_input,train_target)
score = knc.score(test_input,test_target)
print(score)

input_arr = np.array(fish_data)
target_arr = np.array(fish_target)

print(input_arr.shape)

np.random.seed(42)   # seed값..
index = np.arange(49)   # [0,1,2,3,4,5,6,8,9,10,~48]
# print(index)
np.random.shuffle(index)
# print(index)

# print(input_arr[[1,3]])

train_input = input_arr[index[:35]]
train_target = target_arr[index[:35]]

test_input = input_arr[index[35:]]
test_target = target_arr[index[35:]]

print(train_input.shape)
print(train_target.shape)

print(train_input[:,0])
print(train_input[:,1])

plt.scatter(train_input[:,0],train_input[:,1])
plt.scatter(test_input[:,0],test_input[:,1])
plt.xlabel('length')
plt.ylabel('weight')
plt.show()

knc = KNeighborsClassifier()
knc.fit(train_input,train_target)
score = knc.score(test_input,test_target)
print(score)

prevalues = knc.predict([[10,20],[30,500],[40,300]])
print("예측값",prevalues)

print(test_input)
prevalues = knc.predict(test_input)
print("예측값",prevalues)
print("실제값",test_target)



