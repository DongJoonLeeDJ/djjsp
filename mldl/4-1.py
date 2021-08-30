import numpy as np
import pandas as pd

from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.neighbors import KNeighborsClassifier
from sklearn.preprocessing import PolynomialFeatures
from sklearn.linear_model import LogisticRegression
import matplotlib.pyplot as plt

fish = pd.read_csv('https://bit.ly/fish_csv_data')
head = fish.head()
print(head)
# print(fish)

print(pd.unique(fish['Species']))

fish_input = fish[['Weight', 'Length', 'Diagonal', 'Height', 'Width']].to_numpy()
fish_target = fish['Species'].to_numpy()

# print(fish_input[:5])
# print(fish_target[:5])

train_input, test_input, train_target, test_target = \
    train_test_split(fish_input, fish_target, random_state=42)

ss = StandardScaler()
ss.fit(train_input)

train_scaled = ss.transform(train_input)
test_scaled = ss.transform(test_input)

poly = PolynomialFeatures()
poly.fit(train_scaled)

train_poly = poly.transform(train_scaled)
test_poly = poly.transform(test_scaled)

print('train_poly.shape',train_poly.shape)
print('test_poly.shape',test_poly.shape)

# print(train_scaled[:5])
# print(train_target[:5])
# print(test_scaled[:5])
# print(test_target[:5])

kclf = KNeighborsClassifier(n_neighbors=5)
kclf.fit(train_poly, train_target)

print(kclf.score(train_poly, train_target))
print(kclf.score(test_poly, test_target))


mydata = np.array([
    [242, 25.4, 30, 11.52, 4.02],
    [130, 21.3, 22.8, 6.384, 3.534],
    [6.7,9.8,10.8,1.7388,1.0476],
    [40,14.1,16.2,4.1472,2.268],
])

print(mydata)
print(mydata.shape)

mydata_scaled = ss.transform(mydata)
print(mydata_scaled)

mydata_poly = poly.transform(mydata_scaled)

# bream perch smelt roach
mydata_target = kclf.predict(mydata_poly)
print(mydata_target)

lr = LogisticRegression()
lr.fit(train_poly,train_target)

print(lr.score(train_poly, train_target))
print(lr.score(test_poly, test_target))

mydata_target = lr.predict(mydata_poly)
print(mydata_target)

# z = np.arange(-5, 5, 0.1)
# phi = 1 / (1 + np.exp(-z))
#
# plt.plot(z, phi)
# plt.xlabel('z')
# plt.ylabel('phi')
# plt.show()

bream_smelt_indexes = (train_target == 'Bream') | (train_target == 'Smelt')
# print(bream_smelt_indexes)
train_bream_smelt = train_scaled[bream_smelt_indexes]
target_bream_smelt = train_target[bream_smelt_indexes]

# print(train_bream_smelt)
# print(target_bream_smelt)

lr = LogisticRegression()
lr.fit(train_bream_smelt,target_bream_smelt)

# 5개의 input 값에 예측되는 target값 출력 
print(lr.predict(train_bream_smelt[:5]))
# 5개의 input 값에 예측되는 target의 확률값 출력
print(lr.predict_proba(train_bream_smelt[:5]))

decisions = lr.decision_function(train_bream_smelt[:5])
print(decisions)

from scipy.special import expit

print(expit(decisions))

lr = LogisticRegression(C=30, max_iter=1000)
lr.fit(train_scaled, train_target)

print(lr.score(train_scaled, train_target))
print(lr.score(test_scaled, test_target))

print(lr.predict(mydata_scaled))
print(lr.classes_)
print(np.round(lr.predict_proba(mydata_scaled),decimals=3))

decisions = lr.decision_function(mydata_scaled)
print(np.round(decisions,decimals=3))

from scipy.special import softmax

proba = softmax(decisions, axis=1)
print(np.round(proba,decimals=3))
