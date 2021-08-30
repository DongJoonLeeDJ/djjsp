import pandas as pd
import numpy as np

from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.linear_model import SGDClassifier

import matplotlib.pyplot as plt

# from sklearn.linear_model import LogisticRegression
# from sklearn.neighbors import KNeighborsClassifier
''' 
Regressor -> 가로 세로 높이 넓이 대각선 -> 무게 weight 
Classifier -> 분류 bream smelt parkki roach whitefish 
'''

fish = pd.read_csv('https://bit.ly/fish_csv_data')

'''
    1. KNeighborClassfier
    2. LinerClassfier
    3. LogisticRegression
    4. SGDClassfier
'''

fish_input = fish[['Weight', 'Length', 'Diagonal', 'Height', 'Width']].to_numpy()
fish_target = fish['Species'].to_numpy()

# def doA(x, y):
#     return x[:3], y[:3], x[3:], y[3:]
#
# x = np.array([11, 22, 33, 44, 55])
# y = np.array([1, 2, 3, 4, 5])
# a, b, c, d = doA(x, y)
# print(a)
# print(b)
# print(c)
# print(d)

train_input, test_input, train_target, test_target \
    = train_test_split(fish_input, fish_target, random_state=42)

ss = StandardScaler()
ss.fit(train_input)

train_scaled = ss.transform(train_input)
test_scaled = ss.transform(test_input)

'''
    [1,2,3,4,5,6] * 3 = [ 3,6,9,12,15,18 ] 
'''

print(np.round(train_scaled[:5], decimals=3))
print(test_scaled[:5])

''' 특성공학... 컬럼수를 늘리고... 규제... 알고리즘 점수를 최대한 높여서... '''

sgd = SGDClassifier(loss='log', max_iter=10, random_state=42)
sgd.fit(train_scaled,train_target)

print(sgd.score(train_scaled,train_target))
print(sgd.score(test_scaled,test_target))

sgd.partial_fit(train_scaled,train_target)

print(sgd.score(train_scaled,train_target))
print(sgd.score(test_scaled,test_target))

sc = SGDClassifier(loss='log', random_state=42)

train_score = []
test_score = []

classes = np.unique(train_target)

for _ in range(0,300):
    sc.partial_fit(train_scaled,train_target,classes=classes)

    trains = sc.score(train_scaled,train_target)
    train_score.append(trains)
    tests = sc.score(test_scaled,test_target)
    test_score.append(tests)

plt.plot(train_score)
plt.plot(test_score)
plt.xlabel('학습횟수')
plt.ylabel('정확도')
plt.show()